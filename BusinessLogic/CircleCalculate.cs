namespace BusinessLogic
{
    public class CircleCalculate
    {
        public CircleCalculate(float radious)
        {
            Radious = radious;
        }

        public float Radious { get; }

        public decimal CheckShape()
        {
            return (decimal)((22/7) * Radious * Radious);
        }
    }

}
