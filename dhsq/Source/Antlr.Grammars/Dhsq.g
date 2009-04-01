grammar Dhsq;

options{
	language=CSharp2;
	output = AST;
	ASTLabelType = CommonTree;
}

tokens
{
	ALL;
	FIELDS;
	FIELD;
	CONDITIONS;
	CONDITION;
}


@header {
using System.Collections;
using System.Collections.Generic;
}

@lexer::namespace  { Motorola.PublicSafety.Platform.DHStore.Compiler  }
@parser::namespace { Motorola.PublicSafety.Platform.DHStore.Compiler }


@members {
	Stack paraphrases = new Stack();
	public override String GetErrorMessage(RecognitionException e, String[] tokenNames){
		String msg = base.GetErrorMessage(e, tokenNames);
		if (paraphrases.Count > 0){
			msg = msg + " " + paraphrases.Peek();
		}
		return msg;
	}
}


/*
 * Example:
 *     from Agencies 
 *     select '/Person/Name' as Name,
 *            '/Person/Children/Name' as Childs
 *      where Name = 'Franco'
 */
query returns [IStatement StatementValue]
@after {Compiler.CheckErrors();}
	:  s = select { $StatementValue = $s.SelectValue; }
	|  insert
	|  update
	|  delete
	|  EOF
	;
	
delete
	:	'delete'
	;
	
insert
	:	'insert'
	;
	
update
	:	'update'
	;
	
select returns [SelectStatement SelectValue]
	:	'from'   { $SelectValue = new SelectStatement(); }
	    i = id   { $SelectValue.SourceId = i.Id; }
	    'select' f=fields      { $SelectValue.Fields  = f.FieldsValue;}
	    ('where' { $SelectValue.Where = new Where(); } 
			e=expression { $SelectValue.Where.Condition = e.ExpressionValue; } )?
	    ('order' 'by' { $SelectValue.OrderBy = new OrderBy(); } 
			o=orders { $SelectValue.OrderBy.Fields = o.IdentifiersValue;   } )?
	;

fields returns [List<Field> FieldsValue]
@init
{
	$FieldsValue = new List<Field>(); 
} 
	:	'*' { $FieldsValue.Add(new Field(){ XPath=string.Empty, Alias=new Identifier(){ Name="ALL" } } ); }
	|	f=field 
		{ 
			$FieldsValue.Add(f.FieldValue); 
		}
		(COMMA f=field 
		{
			$FieldsValue.Add(f.FieldValue); 
		})* 
	;
	
field returns [Field FieldValue]
@init
{
	$FieldValue = new Field(); 
} 
	:	p=TSTRING { $FieldValue.XPath = p.Text; } ('as' i=id { $FieldValue.Alias = i.Id; })?
	;
	 
expression returns [Expression ExpressionValue]
	:	e1=logicExpression 
		{
			$ExpressionValue = e1.ExpressionValue; 
		}
		(
			o=logic	e2=logicExpression
			{
				$ExpressionValue = new LogicExpression()
				{ Left=e1.ExpressionValue, Operator=o.Operator, Right=e2.ExpressionValue }; 
			}
		)*
	;	
	
logicExpression returns [Expression ExpressionValue]
	:	l=left o=op r=right
		{ 
			$ExpressionValue = new SimpleExpression()
			{ Left=l.Node, Operator=o.Operator, Right=r.Node }; 
		}
	|	'(' e=expression { $ExpressionValue = e.ExpressionValue; } ')'
	;
	
left returns [IVisitableNode Node]
	:	s=TSTRING { $Node = new Value(){ Val = s.Text }; }
	|	i=id	  { $Node = i.Id; }	
	;
		
logic returns [LogicOperators Operator]
	:	'and' { $Operator = LogicOperators.And; }
	|	'or'  { $Operator = LogicOperators.Or; }
	;
	
right returns [Value Node]
	:	s=TSTRING { $Node = new Value() { Val = s.Text }; }
	|	i=INT     { $Node = new Value() { Val = i.Text }; }
	;

orders returns [List<Identifier> IdentifiersValue]
@init
{
	$IdentifiersValue = new List<Identifier>(); 
} 
	:	i = id
		{ 
			$IdentifiersValue.Add(i.Id); 
		}
		(COMMA i = id 
		{
			$IdentifiersValue.Add(i.Id);
		})* 
	;
		
op returns [ComparationOperators Operator]
	:	'='		{ $Operator = ComparationOperators.EqualTo; }
	|	'<'		{ $Operator = ComparationOperators.LessThan; }
	|	'>'		{ $Operator = ComparationOperators.GraterThan; }
	|	'!='	{ $Operator = ComparationOperators.NotEqual; }
	|	'<='	{ $Operator = ComparationOperators.LessThanOrEqualTo; }
	|	'=>'	{ $Operator = ComparationOperators.GraterThanOrEqualTo; }
	|	'like'	{ $Operator = ComparationOperators.Like; }
	;
	
id returns [Identifier Id]
	:	i=ID { $Id = new Identifier(){ Name = $i.Text }; }
	;

qualifiedid
	:	ID (DOT ID)*
	;
// $>


TSTRING
    : SQUOTE (~'\'' )* SQUOTE
	;


SQUOTE	
	:	'\''
	;

ID	
	:	CHAR(CHAR|DIGIT)*	
	;


fragment
CHAR
	:	LC|UC
	;

fragment
LC
	:	'a'..'z'
	;

fragment
UC
	:	'A'..'Z'
	;

	

INT
	:	'0'|('1'..'9' DIGIT*)
	;

fragment
DIGIT
	:	'0'..'9'
	;

WS	
	:	('\t'|' '|NEWLINE)+ {$channel=HIDDEN;}
	;

fragment
NEWLINE
	:	'\r'|'\n'
	;

COMMENT	
	:	'/*' (options {greedy=false;}:.)* '*/' {$channel=HIDDEN;}
	;
		
LINECOMMENT
	:	'//' ~('\r'|'\n')* NEWLINE {$channel=HIDDEN;}
	;

DOT
	:	'.'
	;


SEMICOLON
	:	';'
	;

COLON
	:	':'
	;

COMMA
	:	','
	;
