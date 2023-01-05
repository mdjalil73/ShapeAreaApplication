namespace BusinessLogic
{
    public class ShapeFactory
    {

        public static decimal CreateShapeProvider(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            List<string> parseString = input.Split(" ").ToList();

            switch (parseString[0])
            {
                case "Square":
                    var square = new SquareCalculate(Convert.ToInt32(parseString[1]));
                    return square.CheckShape();
                case "Rectangle":
                    var rectangle = new RectangleCalculate(Convert.ToInt32(parseString[1]), Convert.ToInt32(parseString[2]));
                    return rectangle.CheckShape();
                case "Triangle":
                    var triangle = new TriangleCalculate(Convert.ToInt32(parseString[1]), Convert.ToInt32(parseString[2]));
                    return triangle.CheckShape();
                case "Circle":
                    var circle = new CircleCalculate(Convert.ToInt32(parseString[1]));
                    return circle.CheckShape();
                case "Sphere":
                    var sphere=new SphereCalculate(Convert.ToInt32(parseString[1]));
                    return sphere.CheckShape();
                default:
                    throw new ArgumentNullException("Invalid Operation");
            }

        }

    }

}
