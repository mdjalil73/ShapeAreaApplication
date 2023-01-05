using BusinessLogic;

namespace TestArgsInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter command line argument i.e Square 10, Rectangle 20 10, Triangle 15 10, Circle 15, Sphere 20");
            while (true)
            {

                var inputData = Console.ReadLine();

                var result = ShapeFactory.CreateShapeProvider(inputData);
                Console.WriteLine(result);

            }
        }
    }
}