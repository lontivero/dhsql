tree grammar DhsqSemantic;

options{
	language=CSharp2;
	tokenVocab=Dhsq;
	ASTLabelType=CommonTree;
}

@header {
using Motorola.PublicSafety.Platform.DHStore.Compiler;
}


@members {
}



query
@after {Compiler.CheckErrors();}
	:  select
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
	
select
	:	^('from' id ^(FIELDS fields) {Console.WriteLine("paso el select"); } (^(CONDITIONS conditions))?)
	{	Console.WriteLine("SELECT"); }
	;

fields
	:	ALL | field+
	{	Console.WriteLine("\tFIELDS"); }
	;
	
field
	:	^(FIELD str=TSTRING id?)
	{	Console.WriteLine("\tFIELD " + $str.Text  ); }
	;
	 
conditions
	:	^(logic condition condition)
	;	
	
condition
	:	left op^ xvalue
	;
	
left
	:	TSTRING 
	|	id
	;
		
logic
	:	'and'
	|	'or'
	;
	
xvalue
	:	TSTRING 
	|	INT
	;
	
op
	:	'='
	|	'<'
	|	'>'
	|	'!='
	|	'<='
	|	'=>'
	|	'like'
	;
	
id
	:	ID
	;

qualifiedid
	:	ID (DOT ID)*
	;
// $>

