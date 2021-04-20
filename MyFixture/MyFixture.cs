using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATesting;

namespace MyFixture
{
    public class MyFixture: fit.ColumnFixture
    {
        InsuranceService i1 = new InsuranceService();
        public int age;
        public string gender;

        public double CalPremium()
        {
            return i1.CalcPremium(age, gender);
        }
    }
}
