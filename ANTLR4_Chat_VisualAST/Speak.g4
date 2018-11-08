grammar Speak;

/*
 * Parser Rules
 */

chat                : line line EOF ;
line                : name SAYS opinion NEWLINE;
name                : WORD ;
opinion             : TEXT ;

compileUnit
	:	EOF
	;

/*
 * Lexer Rules
 */
fragment LOWERCASE  : [a-z] ;
fragment UPPERCASE  : [A-Z] ;
 
SAYS                : (':') ;
WORD                : (LOWERCASE | UPPERCASE)+ ;
TEXT                : '"' .*? '"' ;
WHITESPACE          : (' '|'\t')+ -> skip ;
NEWLINE             : ('\r'? '\n' | '\r')+ ;

WS
	:	' ' -> channel(HIDDEN)
	;