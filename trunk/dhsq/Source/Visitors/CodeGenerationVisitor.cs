using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.ServiceModel;
using System.Xml.Linq;
using Motorola.PublicSafety.Platform.Common;
using System.Text;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class CodeGenerationVisitor : AbstractVisitor
    {
        private static readonly Guid PawnsDocumentTypeId = 
            new Guid("8BDF1A0A-672D-4080-BC58-AFE908D4C12F");

        #region Private Fields

        private Dictionary<string, Field> fields = new Dictionary<string,Field>();
        private XElement xwhere;
        private XElement xorder;
        private XElement xfield;
        private string xid;
        private string xvalue;
        private string xpath;

        private StringBuilder sb;

        #endregion

        #region Visitor Implementation

        public override IEnumerable VisitSelect(SelectStatement node)
        {
            xwhere = new XElement("Criteria");
            xorder = new XElement("OrderBy");

            base.VisitSelect(node);

            sb = new StringBuilder();

            ExecuteQuery();
            GetDocuments();
            return null;
        }

        private void ExecuteQuery()
        {
            CreateQuery();

            CreateIndexService();
            sb.AppendLine("var queryResult = indexService.QueryData(query);");
            sb.AppendLine("");
            sb.AppendLine("var dataSet = new DataSet();");
            sb.AppendLine("dataSet.ReadXml(new StringReader(queryResult.Data.OuterXml));");
            sb.AppendLine("dataSet.ReadXmlSchema(new StringReader(queryResult.Schema.OuterXml));");
            sb.AppendLine("");
            sb.AppendLine("");
        }

        private void GetDocuments()
        {
            sb.AppendLine("int docCount = dataSet.Tables[0].Rows.Count;");
            sb.AppendLine("List<DocumentInstance> resultSet = new List<DocumentInstance>(docCount);");
            sb.AppendLine("");
            sb.AppendLine("if (docCount > 0)");
            sb.AppendLine("{");

            CreateDocumentService();

            sb.AppendLine("    foreach (DataRow row in dataSet.Tables[0].Rows)");
            sb.AppendLine("    {");
            sb.AppendLine("        var di = docService.GetDocument(");
            sb.AppendLine("            new DocumentInstanceIdentifier(sourceId, new Guid(row[\"InstanceId\"].ToString())));");
            sb.AppendLine("        resultSet.Add(di);");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("");
        }

        public override void VisitField(Field node)
        {
            fields.Add(node.Alias.Name, node);
        }

        public override void VisitSimpleExpression(SimpleExpression expression)
        {
            base.VisitSimpleExpression(expression);

            xfield = new XElement("Field",
                        new XAttribute("path", fields[xid].XPath ),
                        new XAttribute("operator", ComparationsToString(expression.Operator)),
                        new XElement("Value", xvalue));

        }

        public override void VisitLogicExpression(LogicExpression expression)
        {
            expression.Left.Accept(this);
            xwhere.Add(new XElement("And", xfield));
            expression.Right.Accept(this);
            xwhere.Add(new XElement("And", xfield));
        }

        public override void VisitOrderBy(OrderBy orderBy)
        {
            foreach (var id in orderBy.Fields)
            {
                xorder.Add(
                    new XElement("Field", 
                        new XAttribute("path", fields[id.Name].XPath),
                        new XAttribute("mode", "ASC")
                        ));
            }
        }
        
        public override void VisitValue(Value value)
        {
            xvalue = value.Val;
        }

        public override void VisitIdentifier(Identifier identifier)
        {
            xid = identifier.Name;
        }

        #endregion

        #region Helper members

        /// <summary>
        /// Creates the query to be sent to IndexStore.
        /// </summary>
        /// <returns></returns>
        private void CreateQuery()
        {
            XElement queryXML = new XElement("Query",
                new XAttribute("pageNumber", 1),
                new XAttribute("pageSize", 12),
                xwhere, xorder);

            sb.AppendLine ("System.Xml.XmlDocument doc = new System.Xml.XmlDocument();");
            sb.AppendLine ("doc.LoadXml(@\"");
            sb.Append(queryXML.ToString().Replace("\"", "\"\""));
            sb.AppendLine("\")");
            sb.AppendLine("");
            sb.AppendLine("");

            SecurityContext();

            sb.AppendLine("var query = new Query();");
            sb.AppendLine ("query.Spec = doc.DocumentElement;");
            sb.AppendLine ("query.IncludeRowsCount = false;");
            sb.AppendLine ("query.SourceId = PawnsDocumentTypeId;");
            sb.AppendLine("query.SecurityData = securityContext;");
        }

        /// <summary>
        /// Creates the wcf channel of <c>IDocumentService</c>.
        /// </summary>
        /// <returns>The created <c>ChannelFactory</c>.</returns>
        private void CreateDocumentService()
        {
            sb.AppendLine("    ChannelFactory<IDocumentService> channelFactory =");
            sb.AppendLine("        new ChannelFactory<IDocumentService>(\"DocumentService\");");
            sb.AppendLine("");
            sb.AppendLine("    var docService = channelFactory.CreateChannel();");
        }

        /// <summary>
        /// Creates the wcf channel of <c>IIndexService</c>.
        /// </summary>
        /// <returns>The created <c>ChannelFactory</c>.</returns>
        private void CreateIndexService()
        {
            sb.AppendLine("ChannelFactory<IIndexService> channelFactory =");
            sb.AppendLine("    new ChannelFactory<IIndexService>(\"IndexService\");");
            sb.AppendLine("");
            sb.AppendLine("var indexService = channelFactory.CreateChannel();");
            sb.AppendLine("");
        }

        /// <summary>
        /// Create and return a Administrative context.
        /// </summary>
        /// <returns></returns>
        private void SecurityContext()
        {
            sb.AppendLine("var securityContex = new BaseSecurityDataContract(");
            sb.AppendLine("    new Guid(\"a4e00fa1-d64b-476c-b6bf-2343a854d86c\"),");
            sb.AppendLine("    \"admin\",");
            sb.AppendLine("    \"3ZRwlSi7HIPQjzCI1AQ/R0KJH09hZG1pbg==\",");
            sb.AppendLine("    Guid.Empty, null, null,  null);");
            sb.AppendLine("");
        }

        private string ComparationsToString(ComparationOperators comparationOperators)
        {
            string op = string.Empty;
            switch (comparationOperators)
            {
                case ComparationOperators.EqualTo: op = "eq"; break;
                case ComparationOperators.GraterThan: op = "gt"; break;
                case ComparationOperators.LessThan: op = "lt"; break;
                case ComparationOperators.GraterThanOrEqualTo: op = "get"; break;
                case ComparationOperators.LessThanOrEqualTo: op = "leq"; break;
                case ComparationOperators.Like: op = "like"; break;
                case ComparationOperators.NotEqual: op = "neq"; break;
            }
            return op;
        }

        #endregion

    }
}
