using System.Linq;

namespace SquareEveryDigitRematch;

public class Kata
{
	public static int SquareDigits(int number)
	{
		var squares = number
			.ToString()
			.Select(char.GetNumericValue)
			.Select(digit => digit * digit);

		var concatenatedSquares = string.Concat(squares);
		
		return int.Parse(concatenatedSquares);
	}
}