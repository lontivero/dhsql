using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Data;
using System.Collections;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class InterpreterVisitor : AbstractVisitor
    {
        private Dictionary<string, Field> fields = new Dictionary<string,Field>();

        public override IEnumerable VisitSelect(SelectStatement node)
        {
            foreach (var field in node.Fields)
            {
                field.Accept(this);
            }

            var andElement =  new XElement("And");
            foreach(var field in fields)
            {
                andElement.Add( new XAttribute("path", field.Value.XPath) );
                andElement.Add( new XAttribute("operator", field.Value.XPath) );
            }

            var queryXML = new XElement("Query",
                new XElement("Criteria",
                    new XElement("And",
                        new XElement("Field", new XAttribute("Path", 
                            new 
                            )));


            @"<Query>
                    <Criteria>
                        <And>
                            <Field path='/AgencyId' operator='eq'>
                              <Value>{0}</Value>
                            </Field>
                        </And>
                    </Criteria>
                    <OrderBy>
                    </OrderBy>
                </Query>";


            var queryResult = idxService.Query(queryXML.ToString());
            var dataSet = new DataSet();
            dataSet.ReadXml(queryResult.Data);
            dataSet.ReadXmlSchema(queryResult.Schema);

            int docCount = dataSet.Tables[0].Rows.Count;
            if (docCount == 0)
                return null;

            List<DocumentInstance> resultSet = new List<DocumentInstance>(docCount) ;
            foreach (var row in dataSet.Tables[0].Rows)
            {
                var di = docService.GetDocument(fromSourceGuid, new Guid(row["InstanceId"]));
                resultSet.Add(di);
            }

            return resultSet; 
        }

        public override void VisitField(Field node)
        {
            fields.Add(node.Alias.Name, node);
        }

        public override void VisitIdentifier(Identifier identifier)
        {
            Console.Write(identifier.Name);
        }

        public override void VisitSimpleExpression(SimpleExpression expression)
        {
            Console.Write("   ");
            expression.Left.Accept(this);
            Console.Write(" " + expression.Operator.ToString() + " ");
            expression.Right.Accept(this);
        }

        public override void VisitLogicExpression(LogicExpression expression)
        {
            Console.Write("   ");
            expression.Left.Accept(this);
            Console.Write(" " + expression.Operator.ToString() + " ");
            expression.Right.Accept(this);
        }

        public override void VisitValue(Value value)
        {
            Console.Write(value.Val);
        }
    }
}
