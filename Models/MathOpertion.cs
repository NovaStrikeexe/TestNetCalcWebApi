using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCalcWebApi.Models
{
    public interface MathOpertion
    {
        double CalculateResult(double a, double b);
    }
}