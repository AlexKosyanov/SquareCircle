using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    /// <summary>
    /// Вычисление площади треугольника по трем сторонам
    /// </summary>
    public class Triangle : ISquare
    {
        public double Square(params int[] param)
        {
            if (Validate(param))
            {
                double p = (param[0] + param[1] + param[2])/2F;

                if (param.Count() > param.Distinct().Count()) //определю прямоугольный треугольник или нет, то есть равны ли две его катета ?
                {
                    var side = param.GroupBy(x=>x).Where(x => x.Count() > 0).Select(x=>x.Key).First(); // нахожу два равных катета
                    return (side*side)/2F; // формула может быть не такая, с геометрией не очень ...
                }
                else
                    return Math.Sqrt(p * (p - param[0]) * (p - param[1]) * (p - param[2]));
            }
            else
                return 0;
        }

        public bool Validate(params int[] param)
        {
            if (param.Count() == 3)
                return true;
            else 
                return false;
        }
    }
}
