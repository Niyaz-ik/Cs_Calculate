using System;

/// <summary>
/// Это класс с дополнительными функциями для калькулятора
/// </summary>
namespace Lab_1
{
    public class CalculateDop{
        public double Pow(ref double n1, ref double n2){
            n1 = Math.Pow(n1,n2);
            return n1;
        }
        public double And(ref dynamic n1, ref dynamic n2){
            n1 = n1&n2;
            return n1;
        }
        public double Or(ref dynamic n1, ref dynamic n2){
            n1 = n1|n2;
            return n1;
        }
        public double Xor(ref dynamic n1, ref dynamic n2){
            n1 = n1 ^ n2;
            return n1;
        }
        public double Inversion(ref dynamic n1, ref dynamic n2){
            n1 = n1 ^ n2;
            return n1;
        }
    }
}
