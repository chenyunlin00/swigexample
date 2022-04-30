# swigexample
an example of use swig wrap c++ class for csharp


## DEPENDENCY
- swig

## INSTALL
cd cpp && mkdir build && cd build && cmake .. && make swig && make install

## RUN C#
cd csharp && export LD_LIBRARY_PATH=. && dotnet run
