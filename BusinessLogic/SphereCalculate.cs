namespace BusinessLogic
{
    public interface ISphereCalculate
    {
        public decimal CheckShape();
    }
    public class SphereCalculate: ISphereCalculate
    {
        public SphereCalculate(double radious)
        {
            Radious = radious;
        }

        public double Radious { get; }

        public decimal CheckShape()
        {
           return (decimal)(4 *(22 / 7) * Radious * Radious);

        }
    }

}
