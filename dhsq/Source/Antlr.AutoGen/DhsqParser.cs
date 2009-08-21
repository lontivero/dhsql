// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 ..\\Source\\Antlr.Grammars\\Dhsq.g 2009-08-20 08:28:52

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections;
using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

namespace  Motorola.PublicSafety.Platform.DHStore.Compiler 
{
public partial class DhsqParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ALL", 
		"FIELDS", 
		"FIELD", 
		"CONDITIONS", 
		"CONDITION", 
		"COMMA", 
		"TSTRING", 
		"INT", 
		"ID", 
		"DOT", 
		"SQUOTE", 
		"CHAR", 
		"DIGIT", 
		"LC", 
		"UC", 
		"NEWLINE", 
		"WS", 
		"COMMENT", 
		"LINECOMMENT", 
		"SEMICOLON", 
		"COLON", 
		"'delete'", 
		"'insert'", 
		"'update'", 
		"'from'", 
		"'select'", 
		"'where'", 
		"'order'", 
		"'by'", 
		"'*'", 
		"'as'", 
		"'('", 
		"')'", 
		"'and'", 
		"'or'", 
		"'='", 
		"'<'", 
		"'>'", 
		"'!='", 
		"'<='", 
		"'=>'", 
		"'like'"
    };

    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int CHAR = 15;
    public const int CONDITION = 8;
    public const int LINECOMMENT = 22;
    public const int ID = 12;
    public const int EOF = -1;
    public const int COMMA = 9;
    public const int ALL = 4;
    public const int UC = 18;
    public const int DIGIT = 16;
    public const int DOT = 13;
    public const int COMMENT = 21;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int SEMICOLON = 23;
    public const int INT = 11;
    public const int FIELDS = 5;
    public const int SQUOTE = 14;
    public const int CONDITIONS = 7;
    public const int COLON = 24;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int WS = 20;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int NEWLINE = 19;
    public const int T__36 = 36;
    public const int TSTRING = 10;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int LC = 17;
    public const int FIELD = 6;

    // delegates
    // delegators



        public DhsqParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public DhsqParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return DhsqParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "..\\Source\\Antlr.Grammars\\Dhsq.g"; }
    }


    	Stack paraphrases = new Stack();
    	public override String GetErrorMessage(RecognitionException e, String[] tokenNames){
    		String msg = base.GetErrorMessage(e, tokenNames);
    		if (paraphrases.Count > 0){
    			msg = msg + " " + paraphrases.Peek();
    		}
    		return msg;
    	}


    public class query_return : ParserRuleReturnScope
    {
        public IStatement StatementValue;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "query"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:47:1: query returns [IStatement StatementValue] : (s= select | insert | update | delete | EOF );
    public DhsqParser.query_return query() // throws RecognitionException [1]
    {   
        DhsqParser.query_return retval = new DhsqParser.query_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EOF4 = null;
        DhsqParser.select_return s = default(DhsqParser.select_return);

        DhsqParser.insert_return insert1 = default(DhsqParser.insert_return);

        DhsqParser.update_return update2 = default(DhsqParser.update_return);

        DhsqParser.delete_return delete3 = default(DhsqParser.delete_return);


        CommonTree EOF4_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:49:2: (s= select | insert | update | delete | EOF )
            int alt1 = 5;
            switch ( input.LA(1) ) 
            {
            case 28:
            	{
                alt1 = 1;
                }
                break;
            case 26:
            	{
                alt1 = 2;
                }
                break;
            case 27:
            	{
                alt1 = 3;
                }
                break;
            case 25:
            	{
                alt1 = 4;
                }
                break;
            case EOF:
            	{
                alt1 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:49:5: s= select
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_select_in_query112);
                    	s = select();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, s.Tree);
                    	 retval.StatementValue =  ((s != null) ? s.SelectValue : default(SelectStatement)); 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:50:5: insert
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_insert_in_query120);
                    	insert1 = insert();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, insert1.Tree);

                    }
                    break;
                case 3 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:51:5: update
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_update_in_query126);
                    	update2 = update();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, update2.Tree);

                    }
                    break;
                case 4 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:52:5: delete
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_delete_in_query132);
                    	delete3 = delete();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, delete3.Tree);

                    }
                    break;
                case 5 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:53:5: EOF
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	EOF4=(IToken)Match(input,EOF,FOLLOW_EOF_in_query138); 
                    		EOF4_tree = (CommonTree)adaptor.Create(EOF4);
                    		adaptor.AddChild(root_0, EOF4_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
            Compiler.CheckErrors();
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "query"

    public class delete_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "delete"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:56:1: delete : 'delete' ;
    public DhsqParser.delete_return delete() // throws RecognitionException [1]
    {   
        DhsqParser.delete_return retval = new DhsqParser.delete_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal5 = null;

        CommonTree string_literal5_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:57:2: ( 'delete' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:57:4: 'delete'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal5=(IToken)Match(input,25,FOLLOW_25_in_delete150); 
            		string_literal5_tree = (CommonTree)adaptor.Create(string_literal5);
            		adaptor.AddChild(root_0, string_literal5_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "delete"

    public class insert_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "insert"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:60:1: insert : 'insert' ;
    public DhsqParser.insert_return insert() // throws RecognitionException [1]
    {   
        DhsqParser.insert_return retval = new DhsqParser.insert_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal6 = null;

        CommonTree string_literal6_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:61:2: ( 'insert' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:61:4: 'insert'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal6=(IToken)Match(input,26,FOLLOW_26_in_insert162); 
            		string_literal6_tree = (CommonTree)adaptor.Create(string_literal6);
            		adaptor.AddChild(root_0, string_literal6_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "insert"

    public class update_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "update"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:64:1: update : 'update' ;
    public DhsqParser.update_return update() // throws RecognitionException [1]
    {   
        DhsqParser.update_return retval = new DhsqParser.update_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal7 = null;

        CommonTree string_literal7_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:65:2: ( 'update' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:65:4: 'update'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal7=(IToken)Match(input,27,FOLLOW_27_in_update174); 
            		string_literal7_tree = (CommonTree)adaptor.Create(string_literal7);
            		adaptor.AddChild(root_0, string_literal7_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "update"

    public class select_return : ParserRuleReturnScope
    {
        public SelectStatement SelectValue;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "select"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:68:1: select returns [SelectStatement SelectValue] : 'from' i= id 'select' f= fields ( 'where' e= expression )? ( 'order' 'by' o= orders )? ;
    public DhsqParser.select_return select() // throws RecognitionException [1]
    {   
        DhsqParser.select_return retval = new DhsqParser.select_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal8 = null;
        IToken string_literal9 = null;
        IToken string_literal10 = null;
        IToken string_literal11 = null;
        IToken string_literal12 = null;
        DhsqParser.id_return i = default(DhsqParser.id_return);

        DhsqParser.fields_return f = default(DhsqParser.fields_return);

        DhsqParser.expression_return e = default(DhsqParser.expression_return);

        DhsqParser.orders_return o = default(DhsqParser.orders_return);


        CommonTree string_literal8_tree=null;
        CommonTree string_literal9_tree=null;
        CommonTree string_literal10_tree=null;
        CommonTree string_literal11_tree=null;
        CommonTree string_literal12_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:69:2: ( 'from' i= id 'select' f= fields ( 'where' e= expression )? ( 'order' 'by' o= orders )? )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:69:4: 'from' i= id 'select' f= fields ( 'where' e= expression )? ( 'order' 'by' o= orders )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal8=(IToken)Match(input,28,FOLLOW_28_in_select190); 
            		string_literal8_tree = (CommonTree)adaptor.Create(string_literal8);
            		adaptor.AddChild(root_0, string_literal8_tree);

            	 retval.SelectValue =  new SelectStatement(); 
            	PushFollow(FOLLOW_id_in_select205);
            	i = id();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, i.Tree);
            	 retval.SelectValue.SourceId = i.Id; 
            	string_literal9=(IToken)Match(input,29,FOLLOW_29_in_select216); 
            		string_literal9_tree = (CommonTree)adaptor.Create(string_literal9);
            		adaptor.AddChild(root_0, string_literal9_tree);

            	PushFollow(FOLLOW_fields_in_select220);
            	f = fields();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, f.Tree);
            	 retval.SelectValue.Fields  = f.FieldsValue;
            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:72:6: ( 'where' e= expression )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == 30) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // ..\\Source\\Antlr.Grammars\\Dhsq.g:72:7: 'where' e= expression
            	        {
            	        	string_literal10=(IToken)Match(input,30,FOLLOW_30_in_select235); 
            	        		string_literal10_tree = (CommonTree)adaptor.Create(string_literal10);
            	        		adaptor.AddChild(root_0, string_literal10_tree);

            	        	 retval.SelectValue.Where = new Where(); 
            	        	PushFollow(FOLLOW_expression_in_select245);
            	        	e = expression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e.Tree);
            	        	 retval.SelectValue.Where.Condition = e.ExpressionValue; 

            	        }
            	        break;

            	}

            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:74:6: ( 'order' 'by' o= orders )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == 31) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // ..\\Source\\Antlr.Grammars\\Dhsq.g:74:7: 'order' 'by' o= orders
            	        {
            	        	string_literal11=(IToken)Match(input,31,FOLLOW_31_in_select258); 
            	        		string_literal11_tree = (CommonTree)adaptor.Create(string_literal11);
            	        		adaptor.AddChild(root_0, string_literal11_tree);

            	        	string_literal12=(IToken)Match(input,32,FOLLOW_32_in_select260); 
            	        		string_literal12_tree = (CommonTree)adaptor.Create(string_literal12);
            	        		adaptor.AddChild(root_0, string_literal12_tree);

            	        	 retval.SelectValue.OrderBy = new OrderBy(); 
            	        	PushFollow(FOLLOW_orders_in_select270);
            	        	o = orders();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, o.Tree);
            	        	 retval.SelectValue.OrderBy.Fields = o.IdentifiersValue;   

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "select"

    public class fields_return : ParserRuleReturnScope
    {
        public List<Field> FieldsValue;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "fields"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:78:1: fields returns [List<Field> FieldsValue] : ( '*' | f= field ( COMMA f= field )* );
    public DhsqParser.fields_return fields() // throws RecognitionException [1]
    {   
        DhsqParser.fields_return retval = new DhsqParser.fields_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal13 = null;
        IToken COMMA14 = null;
        DhsqParser.field_return f = default(DhsqParser.field_return);


        CommonTree char_literal13_tree=null;
        CommonTree COMMA14_tree=null;


        	retval.FieldsValue =  new List<Field>(); 

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:83:2: ( '*' | f= field ( COMMA f= field )* )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == 33) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == TSTRING) )
            {
                alt5 = 2;
            }
            else 
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:83:4: '*'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal13=(IToken)Match(input,33,FOLLOW_33_in_fields296); 
                    		char_literal13_tree = (CommonTree)adaptor.Create(char_literal13);
                    		adaptor.AddChild(root_0, char_literal13_tree);

                    	 retval.FieldsValue.Add(new Field(){ XPath=string.Empty, Alias=new Identifier(){ Name="ALL" } } ); 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:84:4: f= field ( COMMA f= field )*
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_field_in_fields305);
                    	f = field();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, f.Tree);
                    	 
                    				retval.FieldsValue.Add(f.FieldValue); 
                    			
                    	// ..\\Source\\Antlr.Grammars\\Dhsq.g:88:3: ( COMMA f= field )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( (LA4_0 == COMMA) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:88:4: COMMA f= field
                    			    {
                    			    	COMMA14=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_fields315); 
                    			    		COMMA14_tree = (CommonTree)adaptor.Create(COMMA14);
                    			    		adaptor.AddChild(root_0, COMMA14_tree);

                    			    	PushFollow(FOLLOW_field_in_fields319);
                    			    	f = field();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, f.Tree);

                    			    				retval.FieldsValue.Add(f.FieldValue); 
                    			    			

                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fields"

    public class field_return : ParserRuleReturnScope
    {
        public Field FieldValue;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "field"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:94:1: field returns [Field FieldValue] : p= TSTRING ( 'as' i= id )? ;
    public DhsqParser.field_return field() // throws RecognitionException [1]
    {   
        DhsqParser.field_return retval = new DhsqParser.field_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken p = null;
        IToken string_literal15 = null;
        DhsqParser.id_return i = default(DhsqParser.id_return);


        CommonTree p_tree=null;
        CommonTree string_literal15_tree=null;


        	retval.FieldValue =  new Field(); 

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:99:2: (p= TSTRING ( 'as' i= id )? )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:99:4: p= TSTRING ( 'as' i= id )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	p=(IToken)Match(input,TSTRING,FOLLOW_TSTRING_in_field351); 
            		p_tree = (CommonTree)adaptor.Create(p);
            		adaptor.AddChild(root_0, p_tree);

            	 retval.FieldValue.XPath = p.Text; 
            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:99:46: ( 'as' i= id )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == 34) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // ..\\Source\\Antlr.Grammars\\Dhsq.g:99:47: 'as' i= id
            	        {
            	        	string_literal15=(IToken)Match(input,34,FOLLOW_34_in_field356); 
            	        		string_literal15_tree = (CommonTree)adaptor.Create(string_literal15);
            	        		adaptor.AddChild(root_0, string_literal15_tree);

            	        	PushFollow(FOLLOW_id_in_field360);
            	        	i = id();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, i.Tree);
            	        	 retval.FieldValue.Alias = i.Id; 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "field"

    public class expression_return : ParserRuleReturnScope
    {
        public Expression ExpressionValue;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expression"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:102:1: expression returns [Expression ExpressionValue] : e1= logicExpression (o= logic e2= logicExpression )* ;
    public DhsqParser.expression_return expression() // throws RecognitionException [1]
    {   
        DhsqParser.expression_return retval = new DhsqParser.expression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        DhsqParser.logicExpression_return e1 = default(DhsqParser.logicExpression_return);

        DhsqParser.logic_return o = default(DhsqParser.logic_return);

        DhsqParser.logicExpression_return e2 = default(DhsqParser.logicExpression_return);



        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:103:2: (e1= logicExpression (o= logic e2= logicExpression )* )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:103:4: e1= logicExpression (o= logic e2= logicExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicExpression_in_expression383);
            	e1 = logicExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e1.Tree);

            				retval.ExpressionValue =  e1.ExpressionValue; 
            			
            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:107:3: (o= logic e2= logicExpression )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= 37 && LA7_0 <= 38)) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:108:4: o= logic e2= logicExpression
            			    {
            			    	PushFollow(FOLLOW_logic_in_expression399);
            			    	o = logic();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, o.Tree);
            			    	PushFollow(FOLLOW_logicExpression_in_expression403);
            			    	e2 = logicExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e2.Tree);

            			    					retval.ExpressionValue =  new LogicExpression()
            			    					{ Left=e1.ExpressionValue, Operator=o.Operator, Right=e2.ExpressionValue }; 
            			    				

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class logicExpression_return : ParserRuleReturnScope
    {
        public Expression ExpressionValue;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "logicExpression"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:116:1: logicExpression returns [Expression ExpressionValue] : (l= left o= op r= right | '(' e= expression ')' );
    public DhsqParser.logicExpression_return logicExpression() // throws RecognitionException [1]
    {   
        DhsqParser.logicExpression_return retval = new DhsqParser.logicExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal16 = null;
        IToken char_literal17 = null;
        DhsqParser.left_return l = default(DhsqParser.left_return);

        DhsqParser.op_return o = default(DhsqParser.op_return);

        DhsqParser.right_return r = default(DhsqParser.right_return);

        DhsqParser.expression_return e = default(DhsqParser.expression_return);


        CommonTree char_literal16_tree=null;
        CommonTree char_literal17_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:117:2: (l= left o= op r= right | '(' e= expression ')' )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == TSTRING || LA8_0 == ID) )
            {
                alt8 = 1;
            }
            else if ( (LA8_0 == 35) )
            {
                alt8 = 2;
            }
            else 
            {
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:117:4: l= left o= op r= right
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_left_in_logicExpression432);
                    	l = left();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, l.Tree);
                    	PushFollow(FOLLOW_op_in_logicExpression436);
                    	o = op();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, o.Tree);
                    	PushFollow(FOLLOW_right_in_logicExpression440);
                    	r = right();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, r.Tree);
                    	 
                    				retval.ExpressionValue =  new SimpleExpression()
                    				{ Left=l.Node, Operator=o.Operator, Right=r.Node }; 
                    			

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:122:4: '(' e= expression ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal16=(IToken)Match(input,35,FOLLOW_35_in_logicExpression449); 
                    		char_literal16_tree = (CommonTree)adaptor.Create(char_literal16);
                    		adaptor.AddChild(root_0, char_literal16_tree);

                    	PushFollow(FOLLOW_expression_in_logicExpression453);
                    	e = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, e.Tree);
                    	 retval.ExpressionValue =  e.ExpressionValue; 
                    	char_literal17=(IToken)Match(input,36,FOLLOW_36_in_logicExpression457); 
                    		char_literal17_tree = (CommonTree)adaptor.Create(char_literal17);
                    		adaptor.AddChild(root_0, char_literal17_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicExpression"

    public class left_return : ParserRuleReturnScope
    {
        public IVisitableNode Node;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "left"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:125:1: left returns [IVisitableNode Node] : (s= TSTRING | i= id );
    public DhsqParser.left_return left() // throws RecognitionException [1]
    {   
        DhsqParser.left_return retval = new DhsqParser.left_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken s = null;
        DhsqParser.id_return i = default(DhsqParser.id_return);


        CommonTree s_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:126:2: (s= TSTRING | i= id )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == TSTRING) )
            {
                alt9 = 1;
            }
            else if ( (LA9_0 == ID) )
            {
                alt9 = 2;
            }
            else 
            {
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:126:4: s= TSTRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	s=(IToken)Match(input,TSTRING,FOLLOW_TSTRING_in_left475); 
                    		s_tree = (CommonTree)adaptor.Create(s);
                    		adaptor.AddChild(root_0, s_tree);

                    	 retval.Node =  new Value(){ Val = s.Text }; 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:127:4: i= id
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_id_in_left484);
                    	i = id();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, i.Tree);
                    	 retval.Node =  i.Id; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "left"

    public class logic_return : ParserRuleReturnScope
    {
        public LogicOperators Operator;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "logic"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:130:1: logic returns [LogicOperators Operator] : ( 'and' | 'or' );
    public DhsqParser.logic_return logic() // throws RecognitionException [1]
    {   
        DhsqParser.logic_return retval = new DhsqParser.logic_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal18 = null;
        IToken string_literal19 = null;

        CommonTree string_literal18_tree=null;
        CommonTree string_literal19_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:131:2: ( 'and' | 'or' )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == 37) )
            {
                alt10 = 1;
            }
            else if ( (LA10_0 == 38) )
            {
                alt10 = 2;
            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:131:4: 'and'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal18=(IToken)Match(input,37,FOLLOW_37_in_logic506); 
                    		string_literal18_tree = (CommonTree)adaptor.Create(string_literal18);
                    		adaptor.AddChild(root_0, string_literal18_tree);

                    	 retval.Operator =  LogicOperators.And; 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:132:4: 'or'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal19=(IToken)Match(input,38,FOLLOW_38_in_logic513); 
                    		string_literal19_tree = (CommonTree)adaptor.Create(string_literal19);
                    		adaptor.AddChild(root_0, string_literal19_tree);

                    	 retval.Operator =  LogicOperators.Or; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logic"

    public class right_return : ParserRuleReturnScope
    {
        public Value Node;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "right"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:135:1: right returns [Value Node] : (s= TSTRING | i= INT );
    public DhsqParser.right_return right() // throws RecognitionException [1]
    {   
        DhsqParser.right_return retval = new DhsqParser.right_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken s = null;
        IToken i = null;

        CommonTree s_tree=null;
        CommonTree i_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:136:2: (s= TSTRING | i= INT )
            int alt11 = 2;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == TSTRING) )
            {
                alt11 = 1;
            }
            else if ( (LA11_0 == INT) )
            {
                alt11 = 2;
            }
            else 
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:136:4: s= TSTRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	s=(IToken)Match(input,TSTRING,FOLLOW_TSTRING_in_right534); 
                    		s_tree = (CommonTree)adaptor.Create(s);
                    		adaptor.AddChild(root_0, s_tree);

                    	 retval.Node =  new Value() { Val = s.Text }; 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:137:4: i= INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	i=(IToken)Match(input,INT,FOLLOW_INT_in_right543); 
                    		i_tree = (CommonTree)adaptor.Create(i);
                    		adaptor.AddChild(root_0, i_tree);

                    	 retval.Node =  new Value() { Val = i.Text }; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "right"

    public class orders_return : ParserRuleReturnScope
    {
        public List<Identifier> IdentifiersValue;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "orders"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:140:1: orders returns [List<Identifier> IdentifiersValue] : i= id ( COMMA i= id )* ;
    public DhsqParser.orders_return orders() // throws RecognitionException [1]
    {   
        DhsqParser.orders_return retval = new DhsqParser.orders_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA20 = null;
        DhsqParser.id_return i = default(DhsqParser.id_return);


        CommonTree COMMA20_tree=null;


        	retval.IdentifiersValue =  new List<Identifier>(); 

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:145:2: (i= id ( COMMA i= id )* )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:145:4: i= id ( COMMA i= id )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_id_in_orders574);
            	i = id();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, i.Tree);
            	 
            				retval.IdentifiersValue.Add(i.Id); 
            			
            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:149:3: ( COMMA i= id )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == COMMA) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:149:4: COMMA i= id
            			    {
            			    	COMMA20=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_orders583); 
            			    		COMMA20_tree = (CommonTree)adaptor.Create(COMMA20);
            			    		adaptor.AddChild(root_0, COMMA20_tree);

            			    	PushFollow(FOLLOW_id_in_orders589);
            			    	i = id();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, i.Tree);

            			    				retval.IdentifiersValue.Add(i.Id);
            			    			

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "orders"

    public class op_return : ParserRuleReturnScope
    {
        public ComparationOperators Operator;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "op"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:155:1: op returns [ComparationOperators Operator] : ( '=' | '<' | '>' | '!=' | '<=' | '=>' | 'like' );
    public DhsqParser.op_return op() // throws RecognitionException [1]
    {   
        DhsqParser.op_return retval = new DhsqParser.op_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal21 = null;
        IToken char_literal22 = null;
        IToken char_literal23 = null;
        IToken string_literal24 = null;
        IToken string_literal25 = null;
        IToken string_literal26 = null;
        IToken string_literal27 = null;

        CommonTree char_literal21_tree=null;
        CommonTree char_literal22_tree=null;
        CommonTree char_literal23_tree=null;
        CommonTree string_literal24_tree=null;
        CommonTree string_literal25_tree=null;
        CommonTree string_literal26_tree=null;
        CommonTree string_literal27_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:156:2: ( '=' | '<' | '>' | '!=' | '<=' | '=>' | 'like' )
            int alt13 = 7;
            switch ( input.LA(1) ) 
            {
            case 39:
            	{
                alt13 = 1;
                }
                break;
            case 40:
            	{
                alt13 = 2;
                }
                break;
            case 41:
            	{
                alt13 = 3;
                }
                break;
            case 42:
            	{
                alt13 = 4;
                }
                break;
            case 43:
            	{
                alt13 = 5;
                }
                break;
            case 44:
            	{
                alt13 = 6;
                }
                break;
            case 45:
            	{
                alt13 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d13s0 =
            	        new NoViableAltException("", 13, 0, input);

            	    throw nvae_d13s0;
            }

            switch (alt13) 
            {
                case 1 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:156:4: '='
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal21=(IToken)Match(input,39,FOLLOW_39_in_op614); 
                    		char_literal21_tree = (CommonTree)adaptor.Create(char_literal21);
                    		adaptor.AddChild(root_0, char_literal21_tree);

                    	 retval.Operator =  ComparationOperators.EqualTo; 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:157:4: '<'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal22=(IToken)Match(input,40,FOLLOW_40_in_op622); 
                    		char_literal22_tree = (CommonTree)adaptor.Create(char_literal22);
                    		adaptor.AddChild(root_0, char_literal22_tree);

                    	 retval.Operator =  ComparationOperators.LessThan; 

                    }
                    break;
                case 3 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:158:4: '>'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal23=(IToken)Match(input,41,FOLLOW_41_in_op630); 
                    		char_literal23_tree = (CommonTree)adaptor.Create(char_literal23);
                    		adaptor.AddChild(root_0, char_literal23_tree);

                    	 retval.Operator =  ComparationOperators.GraterThan; 

                    }
                    break;
                case 4 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:159:4: '!='
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal24=(IToken)Match(input,42,FOLLOW_42_in_op638); 
                    		string_literal24_tree = (CommonTree)adaptor.Create(string_literal24);
                    		adaptor.AddChild(root_0, string_literal24_tree);

                    	 retval.Operator =  ComparationOperators.NotEqual; 

                    }
                    break;
                case 5 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:160:4: '<='
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal25=(IToken)Match(input,43,FOLLOW_43_in_op645); 
                    		string_literal25_tree = (CommonTree)adaptor.Create(string_literal25);
                    		adaptor.AddChild(root_0, string_literal25_tree);

                    	 retval.Operator =  ComparationOperators.LessThanOrEqualTo; 

                    }
                    break;
                case 6 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:161:4: '=>'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal26=(IToken)Match(input,44,FOLLOW_44_in_op652); 
                    		string_literal26_tree = (CommonTree)adaptor.Create(string_literal26);
                    		adaptor.AddChild(root_0, string_literal26_tree);

                    	 retval.Operator =  ComparationOperators.GraterThanOrEqualTo; 

                    }
                    break;
                case 7 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:162:4: 'like'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal27=(IToken)Match(input,45,FOLLOW_45_in_op659); 
                    		string_literal27_tree = (CommonTree)adaptor.Create(string_literal27);
                    		adaptor.AddChild(root_0, string_literal27_tree);

                    	 retval.Operator =  ComparationOperators.Like; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "op"

    public class id_return : ParserRuleReturnScope
    {
        public Identifier Id;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "id"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:165:1: id returns [Identifier Id] : i= ID ;
    public DhsqParser.id_return id() // throws RecognitionException [1]
    {   
        DhsqParser.id_return retval = new DhsqParser.id_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken i = null;

        CommonTree i_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:166:2: (i= ID )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:166:4: i= ID
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	i=(IToken)Match(input,ID,FOLLOW_ID_in_id679); 
            		i_tree = (CommonTree)adaptor.Create(i);
            		adaptor.AddChild(root_0, i_tree);

            	 retval.Id =  new Identifier(){ Name = i.Text }; 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "id"

    public class qualifiedid_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "qualifiedid"
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:169:1: qualifiedid : ID ( DOT ID )* ;
    public DhsqParser.qualifiedid_return qualifiedid() // throws RecognitionException [1]
    {   
        DhsqParser.qualifiedid_return retval = new DhsqParser.qualifiedid_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ID28 = null;
        IToken DOT29 = null;
        IToken ID30 = null;

        CommonTree ID28_tree=null;
        CommonTree DOT29_tree=null;
        CommonTree ID30_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:170:2: ( ID ( DOT ID )* )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:170:4: ID ( DOT ID )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	ID28=(IToken)Match(input,ID,FOLLOW_ID_in_qualifiedid692); 
            		ID28_tree = (CommonTree)adaptor.Create(ID28);
            		adaptor.AddChild(root_0, ID28_tree);

            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:170:7: ( DOT ID )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == DOT) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:170:8: DOT ID
            			    {
            			    	DOT29=(IToken)Match(input,DOT,FOLLOW_DOT_in_qualifiedid695); 
            			    		DOT29_tree = (CommonTree)adaptor.Create(DOT29);
            			    		adaptor.AddChild(root_0, DOT29_tree);

            			    	ID30=(IToken)Match(input,ID,FOLLOW_ID_in_qualifiedid697); 
            			    		ID30_tree = (CommonTree)adaptor.Create(ID30);
            			    		adaptor.AddChild(root_0, ID30_tree);


            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "qualifiedid"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_select_in_query112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_insert_in_query120 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_update_in_query126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_delete_in_query132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EOF_in_query138 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_25_in_delete150 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_insert162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_update174 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_select190 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_id_in_select205 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_select216 = new BitSet(new ulong[]{0x0000000200000400UL});
    public static readonly BitSet FOLLOW_fields_in_select220 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_30_in_select235 = new BitSet(new ulong[]{0x0000000800001400UL});
    public static readonly BitSet FOLLOW_expression_in_select245 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_31_in_select258 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_select260 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_orders_in_select270 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_fields296 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_field_in_fields305 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_COMMA_in_fields315 = new BitSet(new ulong[]{0x0000000200000400UL});
    public static readonly BitSet FOLLOW_field_in_fields319 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_TSTRING_in_field351 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_34_in_field356 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_id_in_field360 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicExpression_in_expression383 = new BitSet(new ulong[]{0x0000006000000002UL});
    public static readonly BitSet FOLLOW_logic_in_expression399 = new BitSet(new ulong[]{0x0000000800001400UL});
    public static readonly BitSet FOLLOW_logicExpression_in_expression403 = new BitSet(new ulong[]{0x0000006000000002UL});
    public static readonly BitSet FOLLOW_left_in_logicExpression432 = new BitSet(new ulong[]{0x00003F8000000000UL});
    public static readonly BitSet FOLLOW_op_in_logicExpression436 = new BitSet(new ulong[]{0x0000000000000C00UL});
    public static readonly BitSet FOLLOW_right_in_logicExpression440 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_logicExpression449 = new BitSet(new ulong[]{0x0000000800001400UL});
    public static readonly BitSet FOLLOW_expression_in_logicExpression453 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_36_in_logicExpression457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TSTRING_in_left475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_id_in_left484 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_logic506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_logic513 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TSTRING_in_right534 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_right543 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_id_in_orders574 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_COMMA_in_orders583 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_id_in_orders589 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_39_in_op614 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_op622 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_op630 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_op638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_op645 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_op652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_op659 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_id679 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_qualifiedid692 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_DOT_in_qualifiedid695 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_ID_in_qualifiedid697 = new BitSet(new ulong[]{0x0000000000002002UL});

}
}