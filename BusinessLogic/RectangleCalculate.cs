namespace BusinessLogic
{
    public class RectangleCalculate
    {
        public RectangleCalculate(int width,int length)
        {
            Width = width;
            Length = length;
        }

        public int Length { get; }
        public int Width { get; }

        public decimal CheckShape()
        {
            return Length* Width;
        }
    }

}
