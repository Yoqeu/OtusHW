using PrototypeDZ;

namespace PrototypeTest
{
    public class PrototypeTests
    {
        /// <summary>
        /// Тестирование клонирования базовой фигуры (Shape).
        /// </summary>
        [Fact]
        public void Shape_Clone_ShouldCloneBaseShape()
        {
            Shape original = new("Жёлтый", 75);
            Shape clone = (Shape)original.Clone();

            // Assert: проверяем, что клон не равен оригиналу, но их значения идентичны
            Assert.NotSame(original, clone);
            Assert.Equal(original.Color, clone.Color);
            Assert.Equal(original.Area, clone.Area);
        }

        /// <summary>
        /// Тестирование клонирования прямоугольника (Rectangle).
        /// </summary>
        [Fact]
        public void Rectangle_Clone_ShouldCloneRectangle()
        {
            Rectangle original = new("Чёрный", 2, 10);
            Rectangle clone = (Rectangle)original.Clone();

            // Assert: проверяем, что клон не равен оригиналу, но их значения идентичны
            Assert.NotSame(original, clone);
            Assert.Equal(original.Color, clone.Color);
            Assert.Equal(original.Width, clone.Width);
            Assert.Equal(original.Height, clone.Height);
            Assert.Equal(original.Area, clone.Area);
        }

        /// <summary>
        /// Тестирование клонирования квадрата (Square).
        /// </summary>
        [Fact]
        public void Square_Clone_ShouldCloneSquare()
        {
            Square original = new("Синий", 7);
            Square clone = (Square)original.Clone();

            // Assert: проверяем, что клон не равен оригиналу, но их значения идентичны
            Assert.NotSame(original, clone);
            Assert.Equal(original.Color, clone.Color);
            Assert.Equal(original.Area, clone.Area);
        }

        /// <summary>
        /// Тестирование независимости клонированного объекта от оригинального.
        /// </summary>
        [Fact]
        public void Clone_ShouldCreateIndependentClone()
        {
            Square original = new("Зеленый", 7);
            Square clone = (Square)original.Clone();

            // Изменяем оригинал
            original.Color = "Черный";

            // Assert: проверяем, что клон остался неизменным
            Assert.Equal("Зеленый", clone.Color);

            // Оригинал изменен
            Assert.Equal("Черный", original.Color);
        }

        /// <summary>
        /// Тестирование метода ToString для класса Square.
        /// </summary>
        [Fact]
        public void Square_ToString_ShouldReturnCorrectString()
        {
            // Arrange: создаем объект Square
            Square square = new("Синий", 5);

            // Act: вызываем метод ToString
            string result = square.ToString();

            // Assert: проверяем, что строковое представление корректно
            Assert.Contains("Фигура: Цвет: Синий", result);
            Assert.Contains("Площадь: 25", result);
            Assert.Contains("квадрата: 5", result);
        }
    }
}