using BusinessLogic;
using NUnit.Framework;

namespace ShapeAreaApplication.Tests
{
    public class ShapeFactoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_ShapeFactory_when_empty_throw_exception()
        {
            Assert.Throws<ArgumentNullException>(() => ShapeFactory.CreateShapeProvider(""));
        }
        [Test]
        public void Given_ShapeFactory_when_wrong_shape_throw_exception_with_message()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => ShapeFactory.CreateShapeProvider("asdf"));
            Assert.That(ex.ParamName, Is.EqualTo("Invalid Operation"));
        }

        [Test]
        [TestCase("10", "100")]
        [TestCase("15", "225")]
        public void Given_ShapeFactory_when_Square_with_input_value_return_result(int length, int result)
        {
            Assert.That(result, Is.EqualTo(ShapeFactory.CreateShapeProvider($"Square {length}")));
        }

        [Test]
        [TestCase("20", "10", "200")]
        [TestCase("30", "20", "600")]
        public void Given_ShapeFactory_when_Rectangle_with_input_value_return_result(int width,int length, int result)
        {
            Assert.That(result, Is.EqualTo(ShapeFactory.CreateShapeProvider($"Rectangle {width} {length}")));
        }

        [Test]
        [TestCase("20", "10", "100")]
        [TestCase("40", "20", "400")]
        public void Given_ShapeFactory_when_Triangle_with_input_value_return_result(int width, int length, int result)
        {
            Assert.That(result, Is.EqualTo(ShapeFactory.CreateShapeProvider($"Triangle {width} {length}")));
        }

        [Test]
        [TestCase("7", "147")]
        [TestCase("6", "108")]
        public void Given_ShapeFactory_when_Circle_with_input_value_return_result(float radious, decimal result)
        {
            Assert.That(result, Is.EqualTo(ShapeFactory.CreateShapeProvider($"Circle {radious}")));
        }

        [Test]
        [TestCase("10", "1200")]
        [TestCase("15", "2700")]
        public void Given_ShapeFactory_when_Sphere_with_input_value_return_result(double radious, int result)
        {
            Assert.That(result, Is.EqualTo(ShapeFactory.CreateShapeProvider($"Sphere {radious}")));
        }
    }
}