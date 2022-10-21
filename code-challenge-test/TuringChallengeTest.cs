using code_challenge;
using Xunit;

namespace code_challenge_test;

public class  TuringChallengeTest
{

    [Fact]
    public void TestTuring()
    {
        
        var service = new TuringQuestions();
        
        string[] arr = {"5", "2", "C", "D", "+"};
        
        Assert.True(service.calcPoint(arr).Equals(30));

        var test1 = "{}";

        Assert.True (service.validateChars(test1).Equals("valid"));

        test1 = "{}[]()";

        Assert.True (service.validateChars(test1).Equals("valid"));

        test1 = "{]{}";

        Assert.False (service.validateChars(test1).Equals("valid"));
        test1 = "[{}]";

        Assert.True (service.validateChars(test1).Equals("valid"));


         
    }
}