UnitTesting - is the folder with the solution for two projects: MSTest and NUnitTests - target tests for the calculator dll file.
There are 61 unique tests written as MS and NUnit tests. Code coverage is 68.69%.

Tests were oriented on double type of the values. So given calculator methods were tested in this way.

There are two methods Multiply and Divide that expect parameters in double types.
So String input was skipped there, written unit tests have only double parameters (solution won't be built with usage of not double parameters).

Added screenshots:
1. Visual Studio - Test run.png --- Run tests on Visual Studio
2. Command line - MSTest run.png --- MS tests execution on command line
3. Command line - MSTest run results.png --- MS tests execution results opened in Visual Studio
4. Command line - NUnitTest run.png --- NUnit tests run in command line + opened result file TestResult