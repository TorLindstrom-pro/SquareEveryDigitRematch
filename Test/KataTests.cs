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

    [Theory(DisplayName = "Each digit is squared and concatenated in result")]
    [InlineData(12, 14)]
    [InlineData(9119, 811181)]
    [InlineData(765, 493625)]
    public void EachDigitIsSquaredAndConcatenated(int number, int expectedResult)
    {
        // act
        var result = Kata.SquareDigits(number);
        
        // assert
        Assert.Equal(expectedResult, result);
    }
}