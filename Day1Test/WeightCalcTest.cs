using Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Day1Test
{

    //Given => Method
    //Then => Result
    //Tech =>AAA(Arrange'input,Param',Act'Method',Assert'Compare')
    [TestClass]
    public class WeightCalcTest
    {
        [TestMethod]
        public void GetWight_hight_170_gender_M_return_65()
        {
            //1-Arrnage
            WeightCalc weightCalcFemaleTest = new WeightCalc
            {
                hight = 170,
                gender = 'M'
            };
            //Act
            double actualResult = weightCalcFemaleTest.GetWight();
            double expectedResult = 65;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void GetWight_hight_176_gender_F_return_63()
        {
            //1-Arrnage
            WeightCalc weightCalcFemaleTest = new WeightCalc
            {
                hight = 176,
                gender = 'F'
            };
            //Act
            double actualResult = weightCalcFemaleTest.GetWight();
            double expectedResult = 63;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }
        [TestMethod]
        public void GetWight_hight_170_gender_Z_return_0()
        {
            //1-Arrnage
            WeightCalc weightCalcFemaleTest = new WeightCalc
            {
                hight = 176,
                gender = 'Z'
            };
            //Act
            double actualResult = weightCalcFemaleTest.GetWight();
            double expectedResult = 0;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

    }
}
