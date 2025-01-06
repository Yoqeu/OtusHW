namespace SolidDZ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var settings = new Settings(10, 1, 250);
			var numberGenerator = new AdvancedNumberGenerator(settings.GetStartRange(), settings.GetEndRange());
			var game = new GuessTheNumberGame(settings, numberGenerator);
			game.StartGame(new MyConsolePrinter());
		}
	}
}
