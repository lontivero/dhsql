using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Data;
using System.Collections;
using System.ServiceModel;
using System.IO;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class InterpreterVisitor : AbstractVisitor
    {
        private Dictionary<string, Field> fields = new Dictionary<string,Field>();
        private XElement xcriteria;
        private XElement xfield;
        private string xid;
        private string xvalue;
        private string xpath;

        public InterpreterVisitor()
        {
            xcriteria = new XElement("Criteria");
        }

        public override IEnumerable VisitSelect(SelectStatement node)
        {
            base.VisitSelect(node);

            XElement queryXML = new XElement("Query", xcriteria);
            queryXML.Add(new XElement("OrderBy"));

            Query query = new Query();
            query.SourceId = new Guid();

            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.LoadXml(queryXML.ToString());
            query.Spec = doc.DocumentElement;
            query.IncludeRowsCount = true;

            var docService = CreateDocumentService();
            var idxService = CreateIndexService();
            var queryResult = idxService.QueryData(query);

            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.ReadXml(new StringReader(queryResult.Data.OuterXml));
            dataSet.ReadXmlSchema(new StringReader(queryResult.Schema.OuterXml));

            int docCount = dataSet.Tables[0].Rows.Count;
            if (docCount == 0)
                return null;

            List<DocumentInstance> resultSet = new List<DocumentInstance>(docCount);
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                var di = docService.GetDocument(
                    new DocumentInstanceIdentifier(new Guid(), new Guid(row["InstanceId"].ToString())));
                resultSet.Add(di);
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
            xcriteria.Add(new XElement("And", xfield));
            expression.Right.Accept(this);
            xcriteria.Add(new XElement("And", xfield));
        }

        public override void VisitValue(Value value)
        {
            xvalue = value.Val;
        }

        public override void VisitIdentifier(Identifier identifier)
        {
            xid = identifier.Name;
        }

        private string ComparationsToString(ComparationOperators comparationOperators)
        {
            return "eq";
        }

        #region Helper members

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

        #endregion

    }
}
