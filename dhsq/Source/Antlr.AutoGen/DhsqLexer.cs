// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 ..\\Source\\Antlr.Grammars\\Dhsq.g 2009-03-31 01:32:02

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  Motorola.PublicSafety.Platform.DHStore.Compiler  
{
public partial class DhsqLexer : Lexer {
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
    public const int COMMENT = 21;
    public const int DOT = 13;
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

    public DhsqLexer() 
    {
		InitializeCyclicDFAs();
    }
    public DhsqLexer(ICharStream input)
		: this(input, null) {
    }
    public DhsqLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "..\\Source\\Antlr.Grammars\\Dhsq.g";} 
    }

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:9:7: ( 'delete' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:9:9: 'delete'
            {
            	Match("delete"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:10:7: ( 'insert' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:10:9: 'insert'
            {
            	Match("insert"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:11:7: ( 'update' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:11:9: 'update'
            {
            	Match("update"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:12:7: ( 'from' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:12:9: 'from'
            {
            	Match("from"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:13:7: ( 'select' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:13:9: 'select'
            {
            	Match("select"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:14:7: ( 'where' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:14:9: 'where'
            {
            	Match("where"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:15:7: ( '*' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:15:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:16:7: ( 'as' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:16:9: 'as'
            {
            	Match("as"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:17:7: ( '(' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:17:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:18:7: ( ')' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:18:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:19:7: ( 'and' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:19:9: 'and'
            {
            	Match("and"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:20:7: ( 'or' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:20:9: 'or'
            {
            	Match("or"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:21:7: ( '=' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:21:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:22:7: ( '<' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:22:9: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:23:7: ( '>' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:23:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:24:7: ( '!=' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:24:9: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:25:7: ( '<=' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:25:9: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:26:7: ( '=>' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:26:9: '=>'
            {
            	Match("=>"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:27:7: ( 'like' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:27:9: 'like'
            {
            	Match("like"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "TSTRING"
    public void mTSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TSTRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:162:5: ( SQUOTE (~ '\\'' )* SQUOTE )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:162:7: SQUOTE (~ '\\'' )* SQUOTE
            {
            	mSQUOTE(); 
            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:162:14: (~ '\\'' )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '\u0000' && LA1_0 <= '&') || (LA1_0 >= '(' && LA1_0 <= '\uFFFF')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:162:15: ~ '\\''
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	mSQUOTE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TSTRING"

    // $ANTLR start "SQUOTE"
    public void mSQUOTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SQUOTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:167:2: ( '\\'' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:167:4: '\\''
            {
            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SQUOTE"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:171:2: ( CHAR ( CHAR | DIGIT )* )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:171:4: CHAR ( CHAR | DIGIT )*
            {
            	mCHAR(); 
            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:171:8: ( CHAR | DIGIT )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9') || (LA2_0 >= 'A' && LA2_0 <= 'Z') || (LA2_0 >= 'a' && LA2_0 <= 'z')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "CHAR"
    public void mCHAR() // throws RecognitionException [2]
    {
    		try
    		{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:177:2: ( LC | UC )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHAR"

    // $ANTLR start "LC"
    public void mLC() // throws RecognitionException [2]
    {
    		try
    		{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:182:2: ( 'a' .. 'z' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:182:4: 'a' .. 'z'
            {
            	MatchRange('a','z'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "LC"

    // $ANTLR start "UC"
    public void mUC() // throws RecognitionException [2]
    {
    		try
    		{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:187:2: ( 'A' .. 'Z' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:187:4: 'A' .. 'Z'
            {
            	MatchRange('A','Z'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UC"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:193:2: ( '0' | ( '1' .. '9' ( DIGIT )* ) )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == '0') )
            {
                alt4 = 1;
            }
            else if ( ((LA4_0 >= '1' && LA4_0 <= '9')) )
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
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:193:4: '0'
                    {
                    	Match('0'); 

                    }
                    break;
                case 2 :
                    // ..\\Source\\Antlr.Grammars\\Dhsq.g:193:8: ( '1' .. '9' ( DIGIT )* )
                    {
                    	// ..\\Source\\Antlr.Grammars\\Dhsq.g:193:8: ( '1' .. '9' ( DIGIT )* )
                    	// ..\\Source\\Antlr.Grammars\\Dhsq.g:193:9: '1' .. '9' ( DIGIT )*
                    	{
                    		MatchRange('1','9'); 
                    		// ..\\Source\\Antlr.Grammars\\Dhsq.g:193:18: ( DIGIT )*
                    		do 
                    		{
                    		    int alt3 = 2;
                    		    int LA3_0 = input.LA(1);

                    		    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    		    {
                    		        alt3 = 1;
                    		    }


                    		    switch (alt3) 
                    			{
                    				case 1 :
                    				    // ..\\Source\\Antlr.Grammars\\Dhsq.g:193:18: DIGIT
                    				    {
                    				    	mDIGIT(); 

                    				    }
                    				    break;

                    				default:
                    				    goto loop3;
                    		    }
                    		} while (true);

                    		loop3:
                    			;	// Stops C# compiler whining that label 'loop3' has no statements


                    	}


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "DIGIT"
    public void mDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:198:2: ( '0' .. '9' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:198:4: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIGIT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:202:2: ( ( '\\t' | ' ' | NEWLINE )+ )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:202:4: ( '\\t' | ' ' | NEWLINE )+
            {
            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:202:4: ( '\\t' | ' ' | NEWLINE )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= '\t' && LA5_0 <= '\n') || LA5_0 == '\r' || LA5_0 == ' ') )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee5 =
            		                new EarlyExitException(5, input);
            		            throw eee5;
            	    }
            	    cnt5++;
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:207:2: ( '\\r' | '\\n' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:
            {
            	if ( input.LA(1) == '\n' || input.LA(1) == '\r' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWLINE"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:211:2: ( '/*' ( options {greedy=false; } : . )* '*/' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:211:4: '/*' ( options {greedy=false; } : . )* '*/'
            {
            	Match("/*"); 

            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:211:9: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == '*') )
            	    {
            	        int LA6_1 = input.LA(2);

            	        if ( (LA6_1 == '/') )
            	        {
            	            alt6 = 2;
            	        }
            	        else if ( ((LA6_1 >= '\u0000' && LA6_1 <= '.') || (LA6_1 >= '0' && LA6_1 <= '\uFFFF')) )
            	        {
            	            alt6 = 1;
            	        }


            	    }
            	    else if ( ((LA6_0 >= '\u0000' && LA6_0 <= ')') || (LA6_0 >= '+' && LA6_0 <= '\uFFFF')) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:211:34: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	Match("*/"); 

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "LINECOMMENT"
    public void mLINECOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LINECOMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:215:2: ( '//' (~ ( '\\r' | '\\n' ) )* NEWLINE )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:215:4: '//' (~ ( '\\r' | '\\n' ) )* NEWLINE
            {
            	Match("//"); 

            	// ..\\Source\\Antlr.Grammars\\Dhsq.g:215:9: (~ ( '\\r' | '\\n' ) )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= '\u0000' && LA7_0 <= '\t') || (LA7_0 >= '\u000B' && LA7_0 <= '\f') || (LA7_0 >= '\u000E' && LA7_0 <= '\uFFFF')) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // ..\\Source\\Antlr.Grammars\\Dhsq.g:215:9: ~ ( '\\r' | '\\n' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	mNEWLINE(); 
            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LINECOMMENT"

    // $ANTLR start "DOT"
    public void mDOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:219:2: ( '.' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:219:4: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOT"

    // $ANTLR start "SEMICOLON"
    public void mSEMICOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SEMICOLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:224:2: ( ';' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:224:4: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SEMICOLON"

    // $ANTLR start "COLON"
    public void mCOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:228:2: ( ':' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:228:4: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COLON"

    // $ANTLR start "COMMA"
    public void mCOMMA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:232:2: ( ',' )
            // ..\\Source\\Antlr.Grammars\\Dhsq.g:232:4: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMA"

    override public void mTokens() // throws RecognitionException 
    {
        // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:8: ( T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | TSTRING | SQUOTE | ID | INT | WS | COMMENT | LINECOMMENT | DOT | SEMICOLON | COLON | COMMA )
        int alt8 = 30;
        alt8 = dfa8.Predict(input);
        switch (alt8) 
        {
            case 1 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:10: T__25
                {
                	mT__25(); 

                }
                break;
            case 2 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:16: T__26
                {
                	mT__26(); 

                }
                break;
            case 3 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:22: T__27
                {
                	mT__27(); 

                }
                break;
            case 4 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:28: T__28
                {
                	mT__28(); 

                }
                break;
            case 5 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:34: T__29
                {
                	mT__29(); 

                }
                break;
            case 6 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:40: T__30
                {
                	mT__30(); 

                }
                break;
            case 7 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:46: T__31
                {
                	mT__31(); 

                }
                break;
            case 8 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:52: T__32
                {
                	mT__32(); 

                }
                break;
            case 9 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:58: T__33
                {
                	mT__33(); 

                }
                break;
            case 10 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:64: T__34
                {
                	mT__34(); 

                }
                break;
            case 11 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:70: T__35
                {
                	mT__35(); 

                }
                break;
            case 12 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:76: T__36
                {
                	mT__36(); 

                }
                break;
            case 13 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:82: T__37
                {
                	mT__37(); 

                }
                break;
            case 14 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:88: T__38
                {
                	mT__38(); 

                }
                break;
            case 15 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:94: T__39
                {
                	mT__39(); 

                }
                break;
            case 16 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:100: T__40
                {
                	mT__40(); 

                }
                break;
            case 17 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:106: T__41
                {
                	mT__41(); 

                }
                break;
            case 18 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:112: T__42
                {
                	mT__42(); 

                }
                break;
            case 19 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:118: T__43
                {
                	mT__43(); 

                }
                break;
            case 20 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:124: TSTRING
                {
                	mTSTRING(); 

                }
                break;
            case 21 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:132: SQUOTE
                {
                	mSQUOTE(); 

                }
                break;
            case 22 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:139: ID
                {
                	mID(); 

                }
                break;
            case 23 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:142: INT
                {
                	mINT(); 

                }
                break;
            case 24 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:146: WS
                {
                	mWS(); 

                }
                break;
            case 25 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:149: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 26 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:157: LINECOMMENT
                {
                	mLINECOMMENT(); 

                }
                break;
            case 27 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:169: DOT
                {
                	mDOT(); 

                }
                break;
            case 28 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:173: SEMICOLON
                {
                	mSEMICOLON(); 

                }
                break;
            case 29 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:183: COLON
                {
                	mCOLON(); 

                }
                break;
            case 30 :
                // ..\\Source\\Antlr.Grammars\\Dhsq.g:1:189: COMMA
                {
                	mCOMMA(); 

                }
                break;

        }

    }


    protected DFA8 dfa8;
	private void InitializeCyclicDFAs()
	{
	    this.dfa8 = new DFA8(this);
	    this.dfa8.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA8_SpecialStateTransition);
	}

    const string DFA8_eotS =
        "\x01\uffff\x06\x12\x01\uffff\x01\x12\x02\uffff\x01\x12\x01\x24"+
        "\x01\x26\x02\uffff\x01\x12\x01\x28\x08\uffff\x06\x12\x01\x32\x01"+
        "\x12\x01\x34\x04\uffff\x01\x12\x04\uffff\x06\x12\x01\uffff\x01\x3c"+
        "\x01\uffff\x04\x12\x01\x41\x02\x12\x01\uffff\x01\x44\x03\x12\x01"+
        "\uffff\x01\x12\x01\x49\x01\uffff\x01\x4a\x01\x4b\x01\x4c\x01\x4d"+
        "\x05\uffff";
    const string DFA8_eofS =
        "\x4e\uffff";
    const string DFA8_minS =
        "\x01\x09\x01\x65\x01\x6e\x01\x70\x01\x72\x01\x65\x01\x68\x01\uffff"+
        "\x01\x6e\x02\uffff\x01\x72\x01\x3e\x01\x3d\x02\uffff\x01\x69\x01"+
        "\x00\x03\uffff\x01\x2a\x04\uffff\x01\x6c\x01\x73\x01\x64\x01\x6f"+
        "\x01\x6c\x01\x65\x01\x30\x01\x64\x01\x30\x04\uffff\x01\x6b\x04\uffff"+
        "\x02\x65\x01\x61\x01\x6d\x01\x65\x01\x72\x01\uffff\x01\x30\x01\uffff"+
        "\x01\x65\x01\x74\x01\x72\x01\x74\x01\x30\x01\x63\x01\x65\x01\uffff"+
        "\x01\x30\x01\x65\x01\x74\x01\x65\x01\uffff\x01\x74\x01\x30\x01\uffff"+
        "\x04\x30\x05\uffff";
    const string DFA8_maxS =
        "\x01\x7a\x01\x65\x01\x6e\x01\x70\x01\x72\x01\x65\x01\x68\x01\uffff"+
        "\x01\x73\x02\uffff\x01\x72\x01\x3e\x01\x3d\x02\uffff\x01\x69\x01"+
        "\uffff\x03\uffff\x01\x2f\x04\uffff\x01\x6c\x01\x73\x01\x64\x01\x6f"+
        "\x01\x6c\x01\x65\x01\x7a\x01\x64\x01\x7a\x04\uffff\x01\x6b\x04\uffff"+
        "\x02\x65\x01\x61\x01\x6d\x01\x65\x01\x72\x01\uffff\x01\x7a\x01\uffff"+
        "\x01\x65\x01\x74\x01\x72\x01\x74\x01\x7a\x01\x63\x01\x65\x01\uffff"+
        "\x01\x7a\x01\x65\x01\x74\x01\x65\x01\uffff\x01\x74\x01\x7a\x01\uffff"+
        "\x04\x7a\x05\uffff";
    const string DFA8_acceptS =
        "\x07\uffff\x01\x07\x01\uffff\x01\x09\x01\x0a\x03\uffff\x01\x0f"+
        "\x01\x10\x02\uffff\x01\x16\x01\x17\x01\x18\x01\uffff\x01\x1b\x01"+
        "\x1c\x01\x1d\x01\x1e\x09\uffff\x01\x12\x01\x0d\x01\x11\x01\x0e\x01"+
        "\uffff\x01\x15\x01\x14\x01\x19\x01\x1a\x06\uffff\x01\x08\x01\uffff"+
        "\x01\x0c\x07\uffff\x01\x0b\x04\uffff\x01\x04\x02\uffff\x01\x13\x04"+
        "\uffff\x01\x06\x01\x01\x01\x02\x01\x03\x01\x05";
    const string DFA8_specialS =
        "\x11\uffff\x01\x00\x3c\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x02\x14\x02\uffff\x01\x14\x12\uffff\x01\x14\x01\x0f\x05\uffff"+
            "\x01\x11\x01\x09\x01\x0a\x01\x07\x01\uffff\x01\x19\x01\uffff"+
            "\x01\x16\x01\x15\x0a\x13\x01\x18\x01\x17\x01\x0d\x01\x0c\x01"+
            "\x0e\x02\uffff\x1a\x12\x06\uffff\x01\x08\x02\x12\x01\x01\x01"+
            "\x12\x01\x04\x02\x12\x01\x02\x02\x12\x01\x10\x02\x12\x01\x0b"+
            "\x03\x12\x01\x05\x01\x12\x01\x03\x01\x12\x01\x06\x03\x12",
            "\x01\x1a",
            "\x01\x1b",
            "\x01\x1c",
            "\x01\x1d",
            "\x01\x1e",
            "\x01\x1f",
            "",
            "\x01\x21\x04\uffff\x01\x20",
            "",
            "",
            "\x01\x22",
            "\x01\x23",
            "\x01\x25",
            "",
            "",
            "\x01\x27",
            "\x00\x29",
            "",
            "",
            "",
            "\x01\x2a\x04\uffff\x01\x2b",
            "",
            "",
            "",
            "",
            "\x01\x2c",
            "\x01\x2d",
            "\x01\x2e",
            "\x01\x2f",
            "\x01\x30",
            "\x01\x31",
            "\x0a\x12\x07\uffff\x1a\x12\x06\uffff\x1a\x12",
            "\x01\x33",
            "\x0a\x12\x07\uffff\x1a\x12\x06\uffff\x1a\x12",
            "",
            "",
            "",
            "",
            "\x01\x35",
            "",
            "",
            "",
            "",
            "\x01\x36",
            "\x01\x37",
            "\x01\x38",
            "\x01\x39",
            "\x01\x3a",
            "\x01\x3b",
            "",
            "\x0a\x12\x07\uffff\x1a\x12\x06\uffff\x1a\x12",
            "",
            "\x01\x3d",
            "\x01\x3e",
            "\x01\x3f",
            "\x01\x40",
            "\x0a\x12\x07\uffff\x1a\x12\x06\uffff\x1a\x12",
            "\x01\x42",
            "\x01\x43",
            "",
            "\x0a\x12\x07\uffff\x1a\x12\x06\uffff\x1a\x12",
            "\x01\x45",
            "\x01\x46",
            "\x01\x47",
            "",
            "\x01\x48",
            "\x0a\x12\x07\uffff\x1a\x12\x06\uffff\x1a\x12",
            "",
            "\x0a\x12\x07\uffff\x1a\x12\x06\uffff\x1a\x12",
            "\x0a\x12\x07\uffff\x1a\x12\x06\uffff\x1a\x12",
            "\x0a\x12\x07\uffff\x1a\x12\x06\uffff\x1a\x12",
            "\x0a\x12\x07\uffff\x1a\x12\x06\uffff\x1a\x12",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | TSTRING | SQUOTE | ID | INT | WS | COMMENT | LINECOMMENT | DOT | SEMICOLON | COLON | COMMA );"; }
        }

    }


    protected internal int DFA8_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA8_17 = input.LA(1);

                   	s = -1;
                   	if ( ((LA8_17 >= '\u0000' && LA8_17 <= '\uFFFF')) ) { s = 41; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae8 =
            new NoViableAltException(dfa.Description, 8, _s, input);
        dfa.Error(nvae8);
        throw nvae8;
    }
 
    
}
}