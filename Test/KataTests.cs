using SquareEveryDigitRematch;

namespace Test;

public class KataTests
{
    [Fact]
    public void Test1()
    {
        // act
        var result = Kata.SquareDigits(1);
        
        // assert
        Assert.Equal(1, result);
    }
}