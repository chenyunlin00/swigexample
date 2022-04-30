cmake_minimum_required(VERSION 3.7)
project(MyProject)
 
set(CMAKE_CXX_STANDARD 11)

add_custom_target(swig COMMAND swig -csharp -c++ ${PROJECT_SOURCE_DIR}/example.i)
add_library(mymodule SHARED a.cpp example_wrap.cxx )   #STATIC  or SHARED
 
file(GLOB CSFILES *.cs)
install (FILES ${CSFILES} build/libmymodule.so DESTINATION ${PROJECT_SOURCE_DIR}/../csharp)
