namespace BusinessLogic
{
    public class SquareCalculate
    {
        public SquareCalculate(int length)
        {
            Length = length;
        }

        public int Length { get; }

        public decimal CheckShape()
        {
            return Length * Length;
        }
    }

}
