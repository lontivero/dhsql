// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 ..\\Source\\Antlr.Grammars\\Dhsq.g 2009-03-29 17:21:44

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
    public const int INT = 11;
    public const int SEMICOLON = 23;
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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:68:1: select returns [SelectStatement SelectValue] : 'from' i= id 'select' f= fields ( 'where' e= expression )? ;
    public DhsqParser.select_return select() // throws RecognitionException [1]
    {   
        DhsqParser.select_return retval = new DhsqParser.select_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal8 = null;
        IToken string_literal9 = null;
        IToken string_literal10 = null;
        DhsqParser.id_return i = default(DhsqParser.id_return);

        DhsqParser.fields_return f = default(DhsqParser.fields_return);

        DhsqParser.expression_return e = default(DhsqParser.expression_return);


        CommonTree string_literal8_tree=null;
        CommonTree string_literal9_tree=null;
        CommonTree string_literal10_tree=null;


        	retval.SelectValue =  new SelectStatement(); 

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:73:2: ( 'from' i= id 'select' f= fields ( 'where' e= expression )? )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:73:4: 'from' i= id 'select' f= fields ( 'where' e= expression )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal8=(IToken)Match(input,28,FOLLOW_28_in_select196); 
            		string_literal8_tree = (CommonTree)adaptor.Create(string_literal8);
            		adaptor.AddChild(root_0, string_literal8_tree);

            	PushFollow(FOLLOW_id_in_select208);
            	i = id();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, i.Tree);
            	 retval.SelectValue.SourceId = i.Id; 
            	string_literal9=(IToken)Match(input,29,FOLLOW_29_in_select217); 
            		string_literal9_tree = (CommonTree)adaptor.Create(string_literal9);
            		adaptor.AddChild(root_0, string_literal9_tree);

            	PushFollow(FOLLOW_fields_in_select223);
            	f = fields();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, f.Tree);
            	 retval.SelectValue.Fields = f.FieldsValue;
            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:76:6: ( 'where' e= expression )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == 30) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // ..\\Source\\Antlr.Grammars\\Dhsq.g:76:7: 'where' e= expression
            	        {
            	        	string_literal10=(IToken)Match(input,30,FOLLOW_30_in_select233); 
            	        		string_literal10_tree = (CommonTree)adaptor.Create(string_literal10);
            	        		adaptor.AddChild(root_0, string_literal10_tree);

            	        	PushFollow(FOLLOW_expression_in_select237);
            	        	e = expression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e.Tree);
            	        	 retval.SelectValue.Where = e.ExpressionValue; 

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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:79:1: fields returns [List<Field> FieldsValue] : ( '*' | f= field ( COMMA f= field )* );
    public DhsqParser.fields_return fields() // throws RecognitionException [1]
    {   
        DhsqParser.fields_return retval = new DhsqParser.fields_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal11 = null;
        IToken COMMA12 = null;
        DhsqParser.field_return f = default(DhsqParser.field_return);


        CommonTree char_literal11_tree=null;
        CommonTree COMMA12_tree=null;


        	retval.FieldsValue =  new List<Field>(); 

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:84:2: ( '*' | f= field ( COMMA f= field )* )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == 31) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == TSTRING) )
            {
                alt4 = 2;
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:84:4: '*'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal11=(IToken)Match(input,31,FOLLOW_31_in_fields262); 
                    		char_literal11_tree = (CommonTree)adaptor.Create(char_literal11);
                    		adaptor.AddChild(root_0, char_literal11_tree);

                    	 retval.FieldsValue.Add(new Field(){ XPath=string.Empty, Alias=new Identifier(){ Name="ALL" } } ); 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:85:4: f= field ( COMMA f= field )*
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_field_in_fields271);
                    	f = field();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, f.Tree);
                    	 
                    				retval.FieldsValue.Add(f.FieldValue); 
                    			
                    	// ..\\Source\\Antlr.Grammars\\Dhsq.g:89:3: ( COMMA f= field )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( (LA3_0 == COMMA) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:89:4: COMMA f= field
                    			    {
                    			    	COMMA12=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_fields281); 
                    			    		COMMA12_tree = (CommonTree)adaptor.Create(COMMA12);
                    			    		adaptor.AddChild(root_0, COMMA12_tree);

                    			    	PushFollow(FOLLOW_field_in_fields285);
                    			    	f = field();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, f.Tree);

                    			    				retval.FieldsValue.Add(f.FieldValue); 
                    			    			

                    			    }
                    			    break;

                    			default:
                    			    goto loop3;
                    	    }
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements


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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:95:1: field returns [Field FieldValue] : p= TSTRING ( 'as' i= id )? ;
    public DhsqParser.field_return field() // throws RecognitionException [1]
    {   
        DhsqParser.field_return retval = new DhsqParser.field_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken p = null;
        IToken string_literal13 = null;
        DhsqParser.id_return i = default(DhsqParser.id_return);


        CommonTree p_tree=null;
        CommonTree string_literal13_tree=null;


        	retval.FieldValue =  new Field(); 

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:100:2: (p= TSTRING ( 'as' i= id )? )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:100:4: p= TSTRING ( 'as' i= id )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	p=(IToken)Match(input,TSTRING,FOLLOW_TSTRING_in_field317); 
            		p_tree = (CommonTree)adaptor.Create(p);
            		adaptor.AddChild(root_0, p_tree);

            	 retval.FieldValue.XPath = p.Text; 
            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:100:46: ( 'as' i= id )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == 32) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // ..\\Source\\Antlr.Grammars\\Dhsq.g:100:47: 'as' i= id
            	        {
            	        	string_literal13=(IToken)Match(input,32,FOLLOW_32_in_field322); 
            	        		string_literal13_tree = (CommonTree)adaptor.Create(string_literal13);
            	        		adaptor.AddChild(root_0, string_literal13_tree);

            	        	PushFollow(FOLLOW_id_in_field326);
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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:103:1: expression returns [Expression ExpressionValue] : e1= logicExpression (o= logic e2= logicExpression )* ;
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
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:104:2: (e1= logicExpression (o= logic e2= logicExpression )* )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:104:4: e1= logicExpression (o= logic e2= logicExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicExpression_in_expression349);
            	e1 = logicExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e1.Tree);

            				retval.ExpressionValue =  e1.ExpressionValue; 
            			
            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:108:3: (o= logic e2= logicExpression )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= 35 && LA6_0 <= 36)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:109:4: o= logic e2= logicExpression
            			    {
            			    	PushFollow(FOLLOW_logic_in_expression365);
            			    	o = logic();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, o.Tree);
            			    	PushFollow(FOLLOW_logicExpression_in_expression369);
            			    	e2 = logicExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e2.Tree);

            			    					retval.ExpressionValue =  new LogicExpression()
            			    					{ Left=e1.ExpressionValue, Operator=o.Operator, Right=e2.ExpressionValue }; 
            			    				

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:117:1: logicExpression returns [Expression ExpressionValue] : (l= left o= op r= right | '(' e= expression ')' );
    public DhsqParser.logicExpression_return logicExpression() // throws RecognitionException [1]
    {   
        DhsqParser.logicExpression_return retval = new DhsqParser.logicExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal14 = null;
        IToken char_literal15 = null;
        DhsqParser.left_return l = default(DhsqParser.left_return);

        DhsqParser.op_return o = default(DhsqParser.op_return);

        DhsqParser.right_return r = default(DhsqParser.right_return);

        DhsqParser.expression_return e = default(DhsqParser.expression_return);


        CommonTree char_literal14_tree=null;
        CommonTree char_literal15_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:118:2: (l= left o= op r= right | '(' e= expression ')' )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == TSTRING || LA7_0 == ID) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == 33) )
            {
                alt7 = 2;
            }
            else 
            {
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:118:4: l= left o= op r= right
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_left_in_logicExpression398);
                    	l = left();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, l.Tree);
                    	PushFollow(FOLLOW_op_in_logicExpression402);
                    	o = op();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, o.Tree);
                    	PushFollow(FOLLOW_right_in_logicExpression406);
                    	r = right();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, r.Tree);
                    	 
                    				retval.ExpressionValue =  new SimpleExpression()
                    				{ Left=l.Node, Operator=o.Operator, Right=r.Node }; 
                    			

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:123:4: '(' e= expression ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal14=(IToken)Match(input,33,FOLLOW_33_in_logicExpression415); 
                    		char_literal14_tree = (CommonTree)adaptor.Create(char_literal14);
                    		adaptor.AddChild(root_0, char_literal14_tree);

                    	PushFollow(FOLLOW_expression_in_logicExpression419);
                    	e = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, e.Tree);
                    	 retval.ExpressionValue =  e.ExpressionValue; 
                    	char_literal15=(IToken)Match(input,34,FOLLOW_34_in_logicExpression423); 
                    		char_literal15_tree = (CommonTree)adaptor.Create(char_literal15);
                    		adaptor.AddChild(root_0, char_literal15_tree);


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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:126:1: left returns [IVisitableNode Node] : (s= TSTRING | i= id );
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
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:127:2: (s= TSTRING | i= id )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == TSTRING) )
            {
                alt8 = 1;
            }
            else if ( (LA8_0 == ID) )
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
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:127:4: s= TSTRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	s=(IToken)Match(input,TSTRING,FOLLOW_TSTRING_in_left441); 
                    		s_tree = (CommonTree)adaptor.Create(s);
                    		adaptor.AddChild(root_0, s_tree);

                    	 retval.Node =  new Value(){ Val = s.Text }; 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:128:4: i= id
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_id_in_left450);
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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:131:1: logic returns [LogicOperators Operator] : ( 'and' | 'or' );
    public DhsqParser.logic_return logic() // throws RecognitionException [1]
    {   
        DhsqParser.logic_return retval = new DhsqParser.logic_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal16 = null;
        IToken string_literal17 = null;

        CommonTree string_literal16_tree=null;
        CommonTree string_literal17_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:132:2: ( 'and' | 'or' )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == 35) )
            {
                alt9 = 1;
            }
            else if ( (LA9_0 == 36) )
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
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:132:4: 'and'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal16=(IToken)Match(input,35,FOLLOW_35_in_logic472); 
                    		string_literal16_tree = (CommonTree)adaptor.Create(string_literal16);
                    		adaptor.AddChild(root_0, string_literal16_tree);

                    	 retval.Operator =  LogicOperators.And; 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:133:4: 'or'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal17=(IToken)Match(input,36,FOLLOW_36_in_logic479); 
                    		string_literal17_tree = (CommonTree)adaptor.Create(string_literal17);
                    		adaptor.AddChild(root_0, string_literal17_tree);

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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:136:1: right returns [Value Node] : (s= TSTRING | i= INT );
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
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:137:2: (s= TSTRING | i= INT )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == TSTRING) )
            {
                alt10 = 1;
            }
            else if ( (LA10_0 == INT) )
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
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:137:4: s= TSTRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	s=(IToken)Match(input,TSTRING,FOLLOW_TSTRING_in_right500); 
                    		s_tree = (CommonTree)adaptor.Create(s);
                    		adaptor.AddChild(root_0, s_tree);

                    	 retval.Node =  new Value() { Val = s.Text }; 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:138:4: i= INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	i=(IToken)Match(input,INT,FOLLOW_INT_in_right509); 
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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:141:1: op returns [ComparationOperators Operator] : ( '=' | '<' | '>' | '!=' | '<=' | '=>' | 'like' );
    public DhsqParser.op_return op() // throws RecognitionException [1]
    {   
        DhsqParser.op_return retval = new DhsqParser.op_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal18 = null;
        IToken char_literal19 = null;
        IToken char_literal20 = null;
        IToken string_literal21 = null;
        IToken string_literal22 = null;
        IToken string_literal23 = null;
        IToken string_literal24 = null;

        CommonTree char_literal18_tree=null;
        CommonTree char_literal19_tree=null;
        CommonTree char_literal20_tree=null;
        CommonTree string_literal21_tree=null;
        CommonTree string_literal22_tree=null;
        CommonTree string_literal23_tree=null;
        CommonTree string_literal24_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:142:2: ( '=' | '<' | '>' | '!=' | '<=' | '=>' | 'like' )
            int alt11 = 7;
            switch ( input.LA(1) ) 
            {
            case 37:
            	{
                alt11 = 1;
                }
                break;
            case 38:
            	{
                alt11 = 2;
                }
                break;
            case 39:
            	{
                alt11 = 3;
                }
                break;
            case 40:
            	{
                alt11 = 4;
                }
                break;
            case 41:
            	{
                alt11 = 5;
                }
                break;
            case 42:
            	{
                alt11 = 6;
                }
                break;
            case 43:
            	{
                alt11 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d11s0 =
            	        new NoViableAltException("", 11, 0, input);

            	    throw nvae_d11s0;
            }

            switch (alt11) 
            {
                case 1 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:142:4: '='
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal18=(IToken)Match(input,37,FOLLOW_37_in_op531); 
                    		char_literal18_tree = (CommonTree)adaptor.Create(char_literal18);
                    		adaptor.AddChild(root_0, char_literal18_tree);

                    	 retval.Operator =  ComparationOperators.EqualTo; 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:143:4: '<'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal19=(IToken)Match(input,38,FOLLOW_38_in_op539); 
                    		char_literal19_tree = (CommonTree)adaptor.Create(char_literal19);
                    		adaptor.AddChild(root_0, char_literal19_tree);

                    	 retval.Operator =  ComparationOperators.LessThan; 

                    }
                    break;
                case 3 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:144:4: '>'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal20=(IToken)Match(input,39,FOLLOW_39_in_op547); 
                    		char_literal20_tree = (CommonTree)adaptor.Create(char_literal20);
                    		adaptor.AddChild(root_0, char_literal20_tree);

                    	 retval.Operator =  ComparationOperators.GraterThan; 

                    }
                    break;
                case 4 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:145:4: '!='
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal21=(IToken)Match(input,40,FOLLOW_40_in_op555); 
                    		string_literal21_tree = (CommonTree)adaptor.Create(string_literal21);
                    		adaptor.AddChild(root_0, string_literal21_tree);

                    	 retval.Operator =  ComparationOperators.NotEqual; 

                    }
                    break;
                case 5 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:146:4: '<='
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal22=(IToken)Match(input,41,FOLLOW_41_in_op562); 
                    		string_literal22_tree = (CommonTree)adaptor.Create(string_literal22);
                    		adaptor.AddChild(root_0, string_literal22_tree);

                    	 retval.Operator =  ComparationOperators.LessThanOrEqualTo; 

                    }
                    break;
                case 6 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:147:4: '=>'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal23=(IToken)Match(input,42,FOLLOW_42_in_op569); 
                    		string_literal23_tree = (CommonTree)adaptor.Create(string_literal23);
                    		adaptor.AddChild(root_0, string_literal23_tree);

                    	 retval.Operator =  ComparationOperators.GraterThanOrEqualTo; 

                    }
                    break;
                case 7 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:148:4: 'like'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal24=(IToken)Match(input,43,FOLLOW_43_in_op576); 
                    		string_literal24_tree = (CommonTree)adaptor.Create(string_literal24);
                    		adaptor.AddChild(root_0, string_literal24_tree);

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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:151:1: id returns [Identifier Id] : i= ID ;
    public DhsqParser.id_return id() // throws RecognitionException [1]
    {   
        DhsqParser.id_return retval = new DhsqParser.id_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken i = null;

        CommonTree i_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:152:2: (i= ID )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:152:4: i= ID
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	i=(IToken)Match(input,ID,FOLLOW_ID_in_id596); 
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
    // ..\\Source\\Antlr.Grammars\\Dhsq.g:155:1: qualifiedid : ID ( DOT ID )* ;
    public DhsqParser.qualifiedid_return qualifiedid() // throws RecognitionException [1]
    {   
        DhsqParser.qualifiedid_return retval = new DhsqParser.qualifiedid_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ID25 = null;
        IToken DOT26 = null;
        IToken ID27 = null;

        CommonTree ID25_tree=null;
        CommonTree DOT26_tree=null;
        CommonTree ID27_tree=null;

        try 
    	{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:156:2: ( ID ( DOT ID )* )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:156:4: ID ( DOT ID )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	ID25=(IToken)Match(input,ID,FOLLOW_ID_in_qualifiedid609); 
            		ID25_tree = (CommonTree)adaptor.Create(ID25);
            		adaptor.AddChild(root_0, ID25_tree);

            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:156:7: ( DOT ID )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == DOT) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:156:8: DOT ID
            			    {
            			    	DOT26=(IToken)Match(input,DOT,FOLLOW_DOT_in_qualifiedid612); 
            			    		DOT26_tree = (CommonTree)adaptor.Create(DOT26);
            			    		adaptor.AddChild(root_0, DOT26_tree);

            			    	ID27=(IToken)Match(input,ID,FOLLOW_ID_in_qualifiedid614); 
            			    		ID27_tree = (CommonTree)adaptor.Create(ID27);
            			    		adaptor.AddChild(root_0, ID27_tree);


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
    public static readonly BitSet FOLLOW_28_in_select196 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_id_in_select208 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_select217 = new BitSet(new ulong[]{0x0000000080000400UL});
    public static readonly BitSet FOLLOW_fields_in_select223 = new BitSet(new ulong[]{0x0000000040000002UL});
    public static readonly BitSet FOLLOW_30_in_select233 = new BitSet(new ulong[]{0x0000000200001400UL});
    public static readonly BitSet FOLLOW_expression_in_select237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_fields262 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_field_in_fields271 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_COMMA_in_fields281 = new BitSet(new ulong[]{0x0000000080000400UL});
    public static readonly BitSet FOLLOW_field_in_fields285 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_TSTRING_in_field317 = new BitSet(new ulong[]{0x0000000100000002UL});
    public static readonly BitSet FOLLOW_32_in_field322 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_id_in_field326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicExpression_in_expression349 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_logic_in_expression365 = new BitSet(new ulong[]{0x0000000200001400UL});
    public static readonly BitSet FOLLOW_logicExpression_in_expression369 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_left_in_logicExpression398 = new BitSet(new ulong[]{0x00000FE000000000UL});
    public static readonly BitSet FOLLOW_op_in_logicExpression402 = new BitSet(new ulong[]{0x0000000000000C00UL});
    public static readonly BitSet FOLLOW_right_in_logicExpression406 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_logicExpression415 = new BitSet(new ulong[]{0x0000000200001400UL});
    public static readonly BitSet FOLLOW_expression_in_logicExpression419 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_34_in_logicExpression423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TSTRING_in_left441 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_id_in_left450 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_logic472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_logic479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TSTRING_in_right500 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_right509 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_op531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_op539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_op547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_op555 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_op562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_op569 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_op576 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_id596 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_qualifiedid609 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_DOT_in_qualifiedid612 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_ID_in_qualifiedid614 = new BitSet(new ulong[]{0x0000000000002002UL});

}
}