using System.Security.Cryptography;

namespace SolidDZ
{
	/// <summary>
	/// Класс для генерации случайного числа
	/// </summary>
	public class AdvancedNumberGenerator : NumberGenerator
	{
		public AdvancedNumberGenerator(int startRange, int endRange) : base(startRange, endRange)
		{
		}

		public override int GenerateRandomNumber()
		{
			return RandomNumberGenerator.GetInt32(_startRange, _endRange + 1);
		}
	}
}
