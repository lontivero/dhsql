using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Data;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class InterpreterVisitor : AbstractVisitor
    {
        public override void VisitSelect(SelectStatement node)
        {

            foreach (var f in node.Fields)
            {
                f.Accept(this);
            }

            if (node.Where != null)
            {
                Console.WriteLine("WHERE");
                node.Where.Accept(this);
            }

            var queryXML = new XElement("Query",
                new XElement("And",
                    new XElement("Field",
                        new XElement())));



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
            Console.WriteLine("   {0, -12} AS {1}.text()", node.Alias.Name, node.XPath);
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
