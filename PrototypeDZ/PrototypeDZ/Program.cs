namespace PrototypeDZ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Создаем оригинальные объекты различных фигур
			Shape originalShape = new("Жёлтый", 75);
			Rectangle originalRectangle = new("Чёрный", 2, 10);
			Square originalSquare = new("Синий", 7);

			// Клонируем объекты
			Shape clonedShape = (Shape)originalShape.Clone();
			Rectangle clonedRectangle = (Rectangle)originalRectangle.Clone();
			Square clonedSquare = (Square)originalSquare.Clone();

			// Выводим оригиналы и их клоны
			Console.WriteLine("Оригинал: " + originalShape);
			Console.WriteLine("Клон: " + clonedShape);

			Console.WriteLine("Оригинал: " + originalRectangle);
			Console.WriteLine("Клон: " + clonedRectangle);

			Console.WriteLine("Оригинал: " + originalSquare);
			Console.WriteLine("Клон: " + clonedSquare);
		}
	}
}
