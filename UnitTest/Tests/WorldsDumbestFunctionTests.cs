using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    public static class WorldsDumbestFunctionTests
    {
        // Naming Convention: TestMethodName_StateUnderTest_ExpectedBehavior
        public static void ReturnsSomethingIfZero_WhenInputIsZero_ReturnsSomething()
        {
            try
            {
                // Arrange - Initialize variables, set up necessary objects, and prepare the environment for the test
                int num = 0;
                WorldsDumbestFunction worldsDumbestFunction = new WorldsDumbestFunction();

                // Act - execute the method or functionality being tested
                string result = worldsDumbestFunction.ReturnsSomethingIfZero(num);


                // Assert - whatever is returned from the method, check if it meets the expected outcome

                if (result == "Something")
                {
                    Console.WriteLine("Test Passed: " + result);
                }
                else
                {
                    Console.WriteLine("Test Failed: Expected 'Something', but got " + result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
