/// <summary>
/// Тут находится интерфейс консольного калькулятора.
/// </summary>
using System;


namespace Lab_1
{
    class Program
    {
        static Calculate calculate = new Calculate();
        static CalculateDop calculatedop = new CalculateDop();

/// <summary>
/// Это главный метод программы. Здесь находится интерфейс программы и логика взаимодействия программы с пользователем
/// </summary>
        static void Main()
        {
            do{
            Intro();

            double n1, n2; 
            char sign = ' ';
            bool b = false;
            bool b1 = false;
            bool b3 = false;   
            bool b2 = false;

           do{
            Console.WriteLine("Write a number one (if you want to use a logical operation use a integer number):");
            string s = Console.ReadLine();
            b = double.TryParse(s, out n1);
            if (!b){ Console.WriteLine("Error! Write a correct number!"); }
            }while (!b); 

            while(!b2){
            do{
            Console.WriteLine("Write a sign(+, -, *, /, %, ^, a(and), o(or), x(xor), i(inversion)):");
            string s = Console.ReadLine();
            b1 = char.TryParse(s, out sign);
            if (!b1){ Console.WriteLine("Error! Write a correct sign: +, -, *, /, %, ^, a(and), o(or), x(xor), i(inversion)"); }
            }while (!b1);
            if (sign == '+' || sign == '-' || sign == '*' || sign == '/' || sign == '%' || sign == '^'  || sign == 'a' || sign == 'o' || sign == 'x' || sign == 'i'){   b2 = true; }
            if (!b2){ Console.WriteLine("Error! Write a correct sign: +, -, *, /, %, ^, a(and), o(or), x(xor), i(inversion)");  }
            }

            do{
            Console.WriteLine("Write a number two (if you want to use a logical operation use a integer number)"); 
            string s = Console.ReadLine();
            b3 = double.TryParse(s, out n2);
            if (!b3){ Console.WriteLine("Error! Write a correct number!"); }
            }while (!b3);

            CheckSign(n1, n2, sign);
            }while (AskToUseAgain());
        }

        /// <summary>
        /// Вывод начальных титров.
        /// </summary>
        static void Intro(){
            Console.WriteLine("Welcome to CalculateWorld!!!");
            Console.WriteLine("Here you can count the numbers. It is enough to enter operation of two numbers(for example: 12,4 + 6).");
            Console.WriteLine("Enter an expression: ");
        }
        /// <summary>
        /// Проверяет какой знак написал пользователь и использует методы из класса Calcaulate соответсвенно знаку.
        /// </summary>
        /// <param name="n1">number one</param>
        /// <param name="n2">number two</param>
        /// <param name="sign">sign</param>
        static void CheckSign(double n1, double n2, double sign){
            switch (sign)
                {
                    case '+':
                        calculate.Sum(ref n1, ref n2);
                        WriteSum(n1);
                    break;
                    case '-':
                        calculate.Minus(ref n1, ref n2);
                        WriteMinus(n1);
                    break;    
                    case '*':
                        calculate.Multiply(ref n1, ref n2);
                        WriteMultiply(n1);
                    break;  
                    case '/':
                        calculate.Divide(ref n1, ref n2);
                        WriteDivide(n1);
                    break;  
                    case '%':
                        calculate.Residue(ref n1, ref n2);
                        WriteResidue(n1);
                    break;  
                    case '^':
                        calculatedop.Pow(ref n1, ref n2);
                        WritePow(n1);
                    break; 
                    case 'a':
                        dynamic n3, n4;
                        n3 = (int) n1;
                        n4 = (int) n2;
                        calculatedop.And(ref n3, ref n4);
                        WriteAnd(n3);
                    break; 
                    case 'o':
                        n3 = (int) n1;
                        n4 = (int) n2;
                        calculatedop.Or(ref n3, ref n4);
                        WriteOr(n3);
                    break;   
                     case 'x':
                        n3 = (int) n1;
                        n4 = (int) n2;
                        calculatedop.Xor(ref n3, ref n4);
                        WriteXor(n3);
                    break; 
                    case 'i':
                        n3 = (int) n1;
                        n4 = (int) n2;
                        calculatedop.Inversion(ref n3, ref n4);
                        WriteInversion(n3);
                    break; 
                }
        }

/// <summary>
/// Выводится результат вычисления.
/// </summary>
/// <param name="result">сюда передается результат вычисления</param>
        static void WriteSum(double result){
            Console.WriteLine("Your result: ");
            Console.WriteLine(result);
        }

        static void WriteMinus(double result){
            Console.WriteLine("Your result: ");
            Console.WriteLine(result);
        }        

        static void WriteMultiply(double result){
            Console.WriteLine("Your result: ");
            Console.WriteLine(result);
        }
        static void WriteDivide(double result){
            Console.WriteLine("Your result: ");
            Console.WriteLine(result);
        }
        static void WriteResidue(double result){
            Console.WriteLine("Your result: ");
            Console.WriteLine(result);
        }
        static void WritePow(double result){
            Console.WriteLine("Your result: ");
            Console.WriteLine(result);
        }
        static void WriteAnd(double result){
            Console.WriteLine("Your result: ");
            Console.WriteLine(result);
        }
        static void WriteOr(double result){
            Console.WriteLine("Your result: ");
            Console.WriteLine(result);
        }
        static void WriteXor(double result){
            Console.WriteLine("Your result: ");
            Console.WriteLine(result);
        }
        static void WriteInversion(double result){
            Console.WriteLine("Your result: ");
            Console.WriteLine(result);
        }
/// <summary>
/// Спрашивает у пользователя хочет ли он еще раз посчитать на калькуляторе.
/// </summary>
/// <returns>Возвращает true или false в зависимости от выбора пользователя.</returns>
        static bool AskToUseAgain(){
            Console.WriteLine("Would you like to calculate again?(Y or y/anything else)");
            char answer = Convert.ToChar(Console.ReadLine());
            bool b = true;
            do{
                if (answer == 'Y' || answer == 'y'){
                    return true;
                } else {
                    return false;
                }
            } while (b == true);
        }
    }
}
