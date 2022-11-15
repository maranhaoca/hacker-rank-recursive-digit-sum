using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var n = "9875";
        var k = 4;

        var expected = 8;
        var actual = Result.superDigit(n,k);

        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void Test3()
    {
        var n = "148 3";
        var k = 3;

        var expected = 3;
        var actual = Result.superDigit(n,k);

        Assert.Equal(expected,actual);
    }
}