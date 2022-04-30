%module mymodule 
%{
#include "a.h"
%}
%include "std_string.i"
%include "a.h"
