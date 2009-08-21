using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.ServiceModel;
using System.Xml.Linq;
using Motorola.PublicSafety.Platform.Common;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class InterpreterVisitor : AbstractVisitor
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

        #endregion

        #region Visitor Implementation

        public override IEnumerable VisitSelect(SelectStatement node)
        {
            xwhere = new XElement("Criteria");
            xorder = new XElement("OrderBy");

            base.VisitSelect(node);

            DataSet dataSet = ExecuteQuery();
            IEnumerable documentInstances = GetDocuments(PawnsDocumentTypeId, dataSet);
            return documentInstances;
        }

        private DataSet ExecuteQuery()
        {
            Query query = CreateQuery();

            var idxService = CreateIndexService();
            var queryResult = idxService.QueryData(query);

            var dataSet = new DataSet();
            dataSet.ReadXml(new StringReader(queryResult.Data.OuterXml));
            dataSet.ReadXmlSchema(new StringReader(queryResult.Schema.OuterXml));

            return dataSet; 
        }

        private static IEnumerable GetDocuments(Guid sourceId, System.Data.DataSet dataSet)
        {
            int docCount = dataSet.Tables[0].Rows.Count;
            List<DocumentInstance> resultSet = new List<DocumentInstance>(docCount);

            if (docCount > 0)
            {
                var docService = CreateDocumentService();
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    var di = docService.GetDocument(
                        new DocumentInstanceIdentifier(sourceId, new Guid(row["InstanceId"].ToString())));
                    resultSet.Add(di);
                }
            }

            return resultSet;
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
        private Query CreateQuery()
        {
            XElement queryXML = new XElement("Query",
                new XAttribute("pageNumber", 1),
                new XAttribute("pageSize", 12),
                xwhere, xorder);

            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.LoadXml(queryXML.ToString());

            var query = new Query();
            query.Spec = doc.DocumentElement;
            query.IncludeRowsCount = false;
            query.SourceId = PawnsDocumentTypeId;
            query.SecurityData = SecurityContext();
            return query;
        }

        /// <summary>
        /// Creates the wcf channel of <c>IDocumentService</c>.
        /// </summary>
        /// <returns>The created <c>ChannelFactory</c>.</returns>
        private static IDocumentService CreateDocumentService()
        {
            ChannelFactory<IDocumentService> channelFactory =
                new ChannelFactory<IDocumentService>("DocumentService");

            return channelFactory.CreateChannel();
        }

        /// <summary>
        /// Creates the wcf channel of <c>IIndexService</c>.
        /// </summary>
        /// <returns>The created <c>ChannelFactory</c>.</returns>
        private static IIndexService CreateIndexService()
        {
            ChannelFactory<IIndexService> channelFactory =
                new ChannelFactory<IIndexService>("IndexService");

            return channelFactory.CreateChannel();
        }

        /// <summary>
        /// Create and return a Administrative context.
        /// </summary>
        /// <returns></returns>
        private static BaseSecurityDataContract SecurityContext()
        {
            var securityContex = new BaseSecurityDataContract(
                new Guid("a4e00fa1-d64b-476c-b6bf-2343a854d86c"),
                "admin",
                "3ZRwlSi7HIPQjzCI1AQ/R0KJH09hZG1pbg==",
                Guid.Empty,
                null,
                null,
                null);
            return securityContex;
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
