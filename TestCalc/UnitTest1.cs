using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;


namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Plus3and45res48()
        {
            string line = "3+45";
            string res = "48";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Plus98and2res100()
        {
            string line = "98+2";
            string res = "100";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Plus87and9res96()
        {
            string line = "87+9";
            string res = "96";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Minus7and2res5()
        {
            string line = "7-2";
            string res = "5";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Minus99and98res1()
        {
            string line = "99-98";
            string res = "1";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Minus71and53res18()
        {
            string line = "71-53";
            string res = "18";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Multiply3and76res228()
        {
            string line = "3*76";
            string res = "228";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Multiply8and24res192()
        {
            string line = "8*192";
            string res = "192";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Multiply9and1res9()
        {
            string line = "9*1";
            string res = "9";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Divide12and6res2()
        {
            string line = "12/6";
            string res = "2";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Divide925and5res185()
        {
            string line = "925/5";
            string res = "185";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

        [TestMethod]
        public void Divide72and8res9()
        {
            string line = "72/8";
            string res = "9";
            string outcome = new DataTable().Compute(line, null).ToString();
            Assert.AreEqual(res, outcome);
        }

    }
}

