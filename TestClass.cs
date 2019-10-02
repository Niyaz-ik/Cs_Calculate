using Xunit;

namespace Lab_1
{   
     public class TestClass
    {
        Calculate Test = new Calculate();
        double n1,n2,n3;

        [Fact]
        public void PassingSumTest(){
            n1 = 12;
            n2 = 5;
            n3 = 17;
            Assert.Equal(n3, Test.Sum(ref n1, ref n2));
        }

        [Fact]
         public void PassingMinusTest(){
            n1 = 12.5;
            n2 = 5.2;
            n3 = 7.3;
            Assert.Equal(n3, Test.Minus(ref n1, ref n2));
        }
        [Fact]
         public void PassingMultiplyTest(){
            n1 = 12345;
            n2 = 0;
            n3 = 0;
            Assert.Equal(n3, Test.Multiply(ref n1, ref n2));
        }
        [Fact]
         public void PassingDivideTest(){
            n1 = 15;
            n2 = 3;
            n3 = 5;
            Assert.Equal(n3, Test.Divide(ref n1, ref n2));
        }
        [Fact]
         public void PassingResidueTest(){
            n1 = 8;
            n2 = 3;
            n3 = 2;
            Assert.Equal(n3,Test.Residue(ref n1, ref n2));
        }
    }   
}