parser grammar DVOscarParser;

options { tokenVocab=DVOscarLexer; }

dvoscar_file
        : block EOF
        ;

block
        : BEGIN datastore_statement END
        ;
datastore_statement
        : DATASTORE identifier display_name? properties?
        parent_item_statement+
        END_DATASTORE
        ;
parent_item_statement
        : item_statement+
        ;
item_statement
        : ITEM identifier plural? display_name? properties? associations?
            attribute_def+  child_item_statement?
        END_ITEM
        ;
child_item_statement
        : item_statement+
        ;
associations
        : association_def+
        ;
association_def
        : ASSOCIATED identifier cardinality properties?
        ;
cardinality
        : o2o
        | m2m
        ;
o2o
        : ONE_TO_ONE identifier from_key to_key
        ;
m2m
        : MANY_TO_MANY identifier from_key to_key
        ;
from_key
        : KEY identifier
        ;
to_key
        : KEY identifier
        ;
attribute_def
        : identifier attrib_properties
        ;
attrib_properties
        : datatype_def length_def? precision_def? scale_def? default_value? properties? display_name?
        ;
precision_def
        : PRECISION NUMBER_INT
        ;
scale_def
        : SCALE NUMBER_INT
        ;
length_def
        : LENGTH integer_value
        ;
default_value
        : DEFAULT constant
        | DEFAULT function_call
        ;
identifier
        : IDENTIFIER
        ;
datatype_def
        : DATATYPE
        ;
properties
        : property+
        ;
property
        :   LCURLY pair (COMMA pair)* RCURLY
        |   LCURLY RCURLY // empty property
        ;
pair
        : STRING_LITERAL COLON value
        ;
display_name
        : STRING_LITERAL
        ;
plural
        : PLURAL STRING_LITERAL
        ;
array
        :   LBRACK value (COMMA value)* RBRACK
        |   LBRACK RBRACK // empty array
        ;
function_call
        : identifier LPAREN arguments? RPAREN
        ;
arguments
        : argument (COMMA argument)*
        ;
argument
        : function_call
        | identifier
        | value
        ;
value
        :   constant
        |   array   // recursion
        |   TRUE  // keywords
        |   FALSE
        |   NULL
        ;
integer_value
        : sign? NUMBER_INT
        ;
constant
        : STRING_LITERAL // string, datetime or uniqueidentifier
        | integer_value
        | sign? NUMBER_FLOAT
        ;
sign
        : PLUS
        | MINUS
        ;
