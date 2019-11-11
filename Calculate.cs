namespace Lab_1
{
    public class Calculate{
        public double Sum(ref double n1, ref double n2){
            n1 += n2;
            return n1;
        }

        public double Minus(ref double n1, ref double n2){
            n1-= n2;
            return n1;
            // kekss
        }

        public double Multiply(ref double n1, ref double n2){
            n1*= n2;
            return n1;
        }        

        public double Divide(ref double n1, ref double n2){
            n1/= n2;
            return n1;
        }
        public double Residue(ref double n1, ref double n2){
            n1%= n2;
            return n1;
            // test comment 123 456 789
            // add some real code (no)
        }
    }
}