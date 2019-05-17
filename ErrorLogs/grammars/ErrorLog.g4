grammar ErrorLog;

/* perser rules */
logfile : line* EOF ; 

line : ( NULL | logline ) EOL? ;

logline : DASHES datetime 
          skip_to_exception_type 
          EXCEPTION_TYPE_LABEL exception_type
          skip_to_error_label 
          ERROR_LABEL error_and_stacktrace ;

datetime : MONTH day year hour COLON minute AM_PM ;
day : NUMBER ;
year : NUMBER ;
hour : NUMBER ;
minute : NUMBER ;

skip_to_exception_type : ~EXCEPTION_TYPE_LABEL+? ;
skip_to_error_label : ~ERROR_LABEL+? ;

exception_type : class_name ;

error_and_stacktrace : error_message STACK_TRACE_LABEL stack_trace 
                       ( INNNER_EXCEPTION_LABEL .+? )* ;
error_message : ~STACK_TRACE_LABEL+? ;
stack_trace : ( 'at' method_signature )+ ;

method_signature : class_name DOT method_name parameter_list ;
class_name : ( IDENTIFIER DOT )* IDENTIFIER ;
method_name : IDENTIFIER ;
parameter_list : L_PAREN ( type IDENTIFIER ( COMMA type IDENTIFIER )* )? R_PAREN ;

type : IDENTIFIER ( AMP | TICK NUMBER | L_BRACKET R_BRACKET )? ;

/* lexer rules */
NULL : 'NULL' ;

DASHES : '----------------------' ;

DOT : '.' ;
COMMA : ',' ;
AMP : '&' ;
TICK : '`' ;
DASH : '-' ;
STAR : '*' ;
BANG : '!' ;
GT : '>' ;
LT : '<' ;
SINGLE_QUOTE : '\'' ;
DOUBLE_QUOTE : '"' ;
BACK_SLASH : '\\' ;
SLASH : '/' ;
SEMI : ';' ;
QUESTION : '?' ;
PIPE : '|' ;
AT_SIGN : '@' ;
PERCENT : '%' ;
DOLLAR : '$' ;
L_PAREN : '(' ;
R_PAREN : ')' ;
L_BRACKET : '[' ;
R_BRACKET : ']' ;
L_BRACE : '{' ;
R_BRACE : '}' ;
COLON : ':' ;
EQUAL : '=' ;

NUMBER : [0-9]+ ;

MONTH : 'Jan' | 'Feb' | 'Mar' | 'Apr' | 'May' | 'Jun'
      | 'Jul' | 'Aug' | 'Sep' | 'Oct' | 'Nov' | 'Dec' ;

AM_PM : 'AM' | 'PM' ;

EXCEPTION_TYPE_LABEL : 'Exception Type:' ;
ERROR_LABEL : 'Error:' ;
STACK_TRACE_LABEL : 'Stack Trace:' ;
INNNER_EXCEPTION_LABEL : '*** Inner Exception ***' ;

IDENTIFIER : [a-zA-Z_][a-zA-Z0-9_]* ;

EOL : '\r'?'\n' | '\r' ;

WS : [ \t]+ -> skip ;