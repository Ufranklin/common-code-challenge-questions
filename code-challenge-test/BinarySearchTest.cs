using code_challenge;
using Xunit;

namespace code_challenge_test;

public class BinarySearchTest
{

    [Fact]
    public void TestBinaryIterative()
    {

        //the test array

        int[] arrays_ = { 1, 2, 5, 6, 8, 9, 11, 17, 20, 30 };

        //create an instance of the service
        var service = new BinarySearch();

        //search the from the array
        int result = service.BinnarySearch(arrays_, 11);

        //check if result is as expected 
        Assert.Equal(result, 6);


        //search same array nut with recursion impelementation
        int result2 = service.BinarySearchRecursion(arrays_, 30, 0, 9);
        Assert.Equal(result2, 9);


        //check if noth method will arrive ast the same result

        result = service.BinnarySearch(arrays_, 11);
        result2 = service.BinarySearchRecursion(arrays_, 11, 0, 9);
        Assert.Equal(result, result2);

    }
}