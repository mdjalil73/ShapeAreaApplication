namespace BusinessLogic
{
    public class TriangleCalculate
    {
        public TriangleCalculate(int width,int height)
        {
            Width = width;
            Height = height;
        }
        public int Width { get; }
        public int Height { get; }

        public decimal CheckShape()
        {
            return (Width * Height)/2;
        }
    }

}
