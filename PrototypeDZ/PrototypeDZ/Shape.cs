using PrototypeDZ.Interface;

namespace PrototypeDZ
{
    /// <summary>
    /// Класс Shape (Фигура), базовый класс для всех геометрических фигур.
    /// </summary>
    /// <remarks>
    /// Конструктор для создания фигуры с указанным цветом и площадью.
    /// </remarks>
    /// <param name="color">Цвет фигуры</param>
    /// <param name="area">Площадь фигуры</param>
    public class Shape(string color, double area) : ICloneable, IMyCloneable<Shape>
	{
        /// <summary>
        /// Цвет фигуры.
        /// </summary>
        public string Color { get; set; } = color;

        /// <summary>
        /// Площадь фигуры.
        /// </summary>
        public double Area { get; set; } = area;

        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Name { get; set; } = "Произвольная фигура";

        /// <summary>
        /// Метод для клонирования объекта Shape с использованием IMyCloneable.
        /// </summary>
        /// <returns>Клон объекта Shape</returns>
        public virtual Shape MyClone()
		{
			return new Shape(this.Color, this.Area);
		}

		/// <summary>
		/// Реализация метода Clone из интерфейса ICloneable.
		/// </summary>
		/// <returns>Клон объекта Shape</returns>
		public object Clone()
		{
			return MyClone();
		}

		/// <summary>
		/// Переопределение метода ToString для вывода информации о фигуре.
		/// </summary>
		/// <returns>Описание фигуры</returns>
		public override string ToString()
		{
			return $"\n\tФигура: {Name} \n\tЦвет: {Color}, \n\tПлощадь: {Area} кв. ед.";
		}
	}
}
