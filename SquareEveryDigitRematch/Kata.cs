using System.Linq;

namespace SquareEveryDigitRematch;

public class Kata
{
	public static int SquareDigits(int i)
	{
		var squares = i.ToString()
			.Select(c => int.Parse("" + c))
			.Select(digit => digit * digit);
		return int.Parse(string.Join("", squares));
	}
}