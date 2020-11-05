using System;
using System.Collections.Generic;

namespace FluidMan
{
    public class Physics
    {
        public List<double> Calc_Vel(List<double> v_0, double r_0, double r_i)
        {
            List<double> retval=new List<double>(v_0.Count);
            for (int i = 0; i < v_0.Count; i++)
            {
                retval[i] = Math.Pow(r_0 / r_i, 2) * v_0[i];
            }
            return retval;
        }
    }
}
