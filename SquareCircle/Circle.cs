

namespace Square
{
    /// <summary>
    /// Вычисление площади круга по радиусу
    /// </summary>
    public class Circle : ISquare
    {
        public double Square(params int[] param)
        {
            if (Validate(param))
            {
                return Math.Pow(param[0],2) * Math.PI;
            }
            else
            {
                return 0;
            }
        }

        public bool Validate(params int[] param)
        {
            if (param.Count() == 1)
                return true;
            else
                return false;
        }
    }
}
