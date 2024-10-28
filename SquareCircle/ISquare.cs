using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    internal interface ISquare
    {
        double Square(params int[] param);
        bool Validate(params int[] param);
    }
}
