using System;

namespace Lab_1
{
    public class CalculateDop{
        public double Pow(ref double n1, ref double n2){
            n1 = Math.Pow(n1,n2);
            return n1;
        }
    }
}
