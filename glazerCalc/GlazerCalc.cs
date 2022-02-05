using System;
class GlazerCalc
{
	static void Main()
	{
		double width, height, woodLength, glassArea;
		string widthString, heightString;

		Console.WriteLine("input width: ");
        widthString = Console.ReadLine();
		width = double.Parse(widthString);
		Console.WriteLine("input height:");
		heightString = Console.ReadLine();
		height = double.Parse(heightString);

		woodLength = 2 * (width + height) * 3.25;
		glassArea = 2 * (height * width);

		Console.WriteLine("The length of the wood is " + woodLength + " meters");
		Console.WriteLine("The area of the glass is " + glassArea + " square meters");
	}
}
