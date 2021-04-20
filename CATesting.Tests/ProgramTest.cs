using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CATesting;

namespace CATesting.Tests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(10, "female", ExpectedResult = 0.0)]
        [TestCase(20, "female", ExpectedResult = 5.0)]
        [TestCase(40, "female", ExpectedResult = 2.5)]
        [TestCase(60, "female", ExpectedResult = 1.25)]
        [TestCase(10, "male", ExpectedResult = 0.0)]
        [TestCase(20, "male", ExpectedResult = 6.0)]
        [TestCase(40, "male", ExpectedResult = 5.0)]
        [TestCase(60, "male", ExpectedResult = 2.5)]
        [TestCase(10, "UNKNOWN", ExpectedResult = 0.0)]
        public static float Test(int age, string gender)
        {
            InsuranceService i1 = new InsuranceService();

            float actualResult = i1.CalcPremium(age, gender);

            return actualResult;
        }
    }
}
