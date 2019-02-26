NUnit\TestDataApp
---

In TestDataApp you have the Adder class with Add. This simply adds two ints.
You have also PersonData and DisplayNameGenerator classes. The latter simply generates a string with combined properties.
In TestDataApp.Tests you have Data\Adder_Add.txt

**TestCase**

1. Specifying test cases as an attribute
Create a test class (AdderTests) with a test (Add_SpecifiedInput_ExpectedOutput) that verifies Adder.Add for the following cases:
1,2,3
2,3,5
-1,2,1
2. TestCase with the ExpectedResult
Copy the previous test into a new one, specify the expected return value of the method in the attribute and refactor the test.

3. Test case naming - what are auto-generated names of the tests from TestCase

**TestCaseSource**

4. Create the test above with TestCaseSource, simplest form
	a. use nameof for method instead of specifying it a a string
	b. requirements on the data sorce method
	c. passing parameters  - overview
	
5. From  a file: 
Create a class FileTestCaseSource with a method AdderCasesFromFile that reads Data\Adder_Add.txt and returns them in the format suitable for test cases. Note that the file has headers. Use notes for the method if convenient.
Create a test, the same as before, but with the FileTestCaseSource  as the test case source.
What is the current directory when the tests are run? How can you get the test assembly output directory so that you can access the files with test data?

6. TestCaseData: Create one more variant of the same test with the source returning TestCaseData (statically in code, not from a file). Use a test with the return value.


7. Complex types
Create a test class DisplayNameGeneratorTests.
Inside, create a nested class TestDataSource with the GetTestCases method that returns:
new PersonData() { FirstName = "John", LastName = "Doe", Age = 42 }, "John Doe (42)"
new PersonData() { FirstName = "Tom", LastName = "Doe", Age = 30 }, "Tom Doe (30)"
Don't use Returns this time, the expected value should be the method parameter.
Create a test method, GetDisplayName_SpecifiedPersonData_ExpectedDisplayName that takes PersonData and expected display name. Configure it to use the inner class as the test data source.
