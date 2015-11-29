using System;
using System.Linq;
using Xunit;

namespace MyCalculator.Test
{
    public class Computing
    {
        Calculator calc = new Calculator();
        

        [Fact]
        public void Add_HappyCase_Passed()
        {
            //Arrange
            int a = 1; int b = 2;

            //Act
            int result = calc.Add(a,b);

            //Assert
            Assert.Equal(3,result);
        }

        [Fact]
        public void Add_Nullable_HappyCase_Failed()
        {
            //Arrange
             int? a = null; int b = 2;

            //Act
            int result = calc.Add((int)a, b);

            //Assert
            //Assert.Throws<NullReferenceException>(() => "Null value");
            Assert.IsType<NullReferenceException>(result);
        }

        [Fact]
        public void Add_InvalidOperator_HappyCase_Failed()
        {
            //Arrange
            int? a = '3'; int b = 2;

            //Act
            int result = calc.Add((int)a, b);

            //Assert
            //Assert.Throws<InvalidOperationException>(() => "Invalid operator value");
            Assert.IsType < InvalidOperationException>(result);
        }
    }
}
