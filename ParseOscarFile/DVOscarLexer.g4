lexer grammar DVOscarLexer;

ASSOCIATED
    : A S S O C I A T E D
    ;
ATTRIBUTE
   : A T T R I B U T E
   ;
BEGIN
	: B E G I N
	;
COLON
    : ':'
    ;
COMMA
    : ','
    ;
COUNT
    : C O U N T
    ;
DATASTORE
	: D A T A S T O R E
	;
DATATYPE
    : BOOLEAN
    | INTEGER
    | FLOAT
    | GUID
    | CHARACTER
    | NUMERIC
    | STRING
    | DATE
    | TIME
    | DATETIME
    ;
BOOLEAN
    : COLON B O O L E A N
    ;
DATE
    : COLON D A T E
    ;
DEFAULT
    : D E F A U L T
    ;
END
	: E N D
	;
END_ATTRIBUTE
   : E N D '_' A T T R I B U T E
   ;
END_DATASTORE
	: E N D '_' D A T A S T O R E
	;
END_ITEM
	: E N D '_' I T E M
	;
EQUAL
    : '='
    ;
FALSE
    : F A L S E
    ;
CHARACTER
    : COLON C H A R A C T E R
    ;
FLOAT
    : COLON F L O A T
    ;
GUID
    : COLON G U I D
    ;
ITEM
	: I T E M
	;
KEY
    : K E Y
    ;
LBRACK
   : '['
   ;
LCURLY
   : '{'
   ;
LENGTH
    : L E N G T H
    ;
LPAREN
   : '('
   ;
NULL
   : N U L L
   ;
PLURAL
   : P L U R A L
   ;
RBRACK
   : ']'
   ;
RCURLY
   : '}'
   ;
RPAREN
   : ')'
   ;
SCALE
   : S C A L E
   ;
UNDERSCORE
   : '_'
   ;
INTEGER
   : COLON I N T E G E R
   ;
MANY_TO_MANY
   : M A N Y '_' T O '_' M A N Y
   ;
MINUS
   : '-'
   ;
NUMBER_INT
	: DEC_DIGIT+
	;
NUMBER_FLOAT
	: DEC_DOT_DEC
	;
NUMBER
    : NUMBER_INT
    | NUMBER_FLOAT
    ;
NUMERIC
    : COLON N U M E R I C
    ;
ONE_TO_ONE
    : O N E '_' T O '_' O N E
    ;
PLUS
    : '+'
    ;
PRECISION
    : P R E C I S I O N
    ;
STRING
    : COLON S T R I N G
    ;
STRING_LITERAL
   : '"' (~["\\\r\n] | ESCAPE_SEQUENCE)* '"'
   ;
TIME
   : COLON T I M E
   ;
DATETIME
    : COLON D A T E T I M E
    ;
TRUE
    : T R U E
    ;
IDENTIFIER
   : ('a' .. 'z' | 'A' .. 'Z') ('a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_')*
   ;
SPACE:              [ \t\r\n]+    -> skip;
COMMENT:            '/*' (COMMENT | .)*? '*/' -> channel(HIDDEN);
LINE_COMMENT:       '//' ~[\r\n]* -> channel(HIDDEN);

fragment DEC_DOT_DEC:  (DEC_DIGIT+ '.' DEC_DIGIT+ |  DEC_DIGIT+ '.' | '.' DEC_DIGIT+);
fragment HEX_DIGIT:    [0-9A-F];
fragment DEC_DIGIT:    [0-9];

fragment ESCAPE_SEQUENCE
    : '\\' [btnfr"'\\]
    | '\\' ([0-3]? [0-7])? [0-7]
    | '\\' 'u'+ HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
    ;
fragment UNICODE : 'u' HEX HEX HEX HEX ;
fragment HEX : [0-9a-fA-F] ;

fragment A
   : ('a' | 'A')
   ;
fragment B
   : ('b' | 'B')
   ;
fragment C
   : ('c' | 'C')
   ;
fragment D
   : ('d' | 'D')
   ;
fragment E
   : ('e' | 'E')
   ;
fragment F
   : ('f' | 'F')
   ;
fragment G
   : ('g' | 'G')
   ;
fragment H
   : ('h' | 'H')
   ;
fragment I
   : ('i' | 'I')
   ;
fragment J
   : ('j' | 'J')
   ;
fragment K
   : ('k' | 'K')
   ;
fragment L
   : ('l' | 'L')
   ;
fragment M
   : ('m' | 'M')
   ;
fragment N
   : ('n' | 'N')
   ;
fragment O
   : ('o' | 'O')
   ;
fragment P
   : ('p' | 'P')
   ;
fragment Q
   : ('q' | 'Q')
   ;
fragment R
   : ('r' | 'R')
   ;
fragment S
   : ('s' | 'S')
   ;
fragment T
   : ('t' | 'T')
   ;
fragment U
   : ('u' | 'U')
   ;
fragment V
   : ('v' | 'V')
   ;
fragment W
   : ('w' | 'W')
   ;
fragment X
   : ('x' | 'X')
   ;
fragment Y
   : ('y' | 'Y')
   ;
fragment Z
   : ('z' | 'Z')
   ;
