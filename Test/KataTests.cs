using SquareEveryDigitRematch;

namespace Test;

public class KataTests
{
    [Theory(DisplayName = "Single digit returns square of digit")]
    [InlineData(1, 1)]
    [InlineData(2, 4)]
    public void SingleDigitReturnsSquare(int number, int expectedResult)
    {
        // act
        var result = Kata.SquareDigits(number);
        
        // assert
        Assert.Equal(expectedResult, result);
    }

    [Fact(DisplayName = "Each digit is squared and concatenated in result")]
    public void EachDigitIsSquaredAndConcatenated()
    {
        // act
        var result = Kata.SquareDigits(12);
        
        // assert
        Assert.Equal(14, result);
    }
}