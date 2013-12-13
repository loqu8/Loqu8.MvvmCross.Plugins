http://msdn.microsoft.com/en-us/library/zdc263t0(VS.80).aspx

To get the Shared File references to work out, each vstemplate must have CreateInPlace set to true
If you have the Project in a network share, it will trigger a warning for each project unless
you can trust the network share.

TODO: Add MVX to build so that it is easier to do what we did with the files