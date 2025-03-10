using System.Linq;

namespace SquareEveryDigitRematch;

public class Kata
{
	public static int SquareDigits(int i)
	{
		var squares = i
			.ToString()
			.Select(char.GetNumericValue)
			.Select(digit => digit * digit);

		var joinedSquares = string.Concat(squares);
		
		return int.Parse(joinedSquares);
	}
}