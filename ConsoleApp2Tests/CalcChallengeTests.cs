using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass]
    public class CalcChallengeTests
    {
        //[TestMethod()]
        //public void CalcChallengeTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void TestAdd_two_numbers()
        {
            CalcChallenge cc = new CalcChallenge();
            // testing with valid values
            string input = "4,5";
            int expected = 9; // 4 + 5 = 9
            int actual = cc.Add_two_numbers(input);
            Assert.AreEqual(expected, actual, "Adding two numbers failed.");

            // test for invalid characters (string instead of number)
            string invalidInput = "4,rtyuijnnn";
            //Assert.ThrowsException<FormatException>(() => cc.Add_two_numbers(invalidInput), "Invalid number format should throw an exception.");
            
        }

        [TestMethod()]
        public void TestAdd_multiple_numbers()
        {
            CalcChallenge cc = new CalcChallenge();
            string input = "1,2,3,4,5,6,7,8,9,10,11,12";
            int expected = 78; // Sum of numbers 1 to 12
            int actual = cc.Add_multiple_numbers(input);
            Assert.AreEqual(expected, actual, "Adding multiple numbers failed error.");
        }

        [TestMethod()]
        public void TestAdd_multiple_numbers_with_new_Delimiter()
        {
            CalcChallenge cc = new CalcChallenge();
            string input = "1\n2,3";
            int expected = 6; // 1 + 2 + 3 = 6
            int actual = cc.Add_multiple_numbers_with_new_Delimiter(input);
            Assert.AreEqual(expected, actual, "Adding multiple numbers with new line delimiter failed.");
        }

        [TestMethod()]
        public void TestDeny_Negative_Numbers()
        {
            CalcChallenge cc = new CalcChallenge();
            string input = "5,-9,56,-20,-44";
            Assert.ThrowsException<Exception>(() => cc.Deny_Negative_Numbers(input), "Negative numbers are expected to throw an exception.");
        }

        [TestMethod()]
        public void TestInvalidate_Values_Above_1000()
        {
            CalcChallenge cc = new CalcChallenge();
            string input = "2,1001,6";
            int expected = 8; // 2 + 6 = 8 (1001 is ignored)
            int actual = cc.Invalidate_Values_Above_1000(input);
            Assert.AreEqual(expected, actual, "Invalidating values above 1000 failed.");
        }

        [TestMethod()]
        public void TestAdd_multiple_numbers_with_One_Delimiter()
        {
            CalcChallenge cc = new CalcChallenge();
            string input = "#\n2#5";
            int expected = 7; // 2 + 5 = 7
            int actual = cc.Add_multiple_numbers_with_One_Delimiter(input);
            Assert.AreEqual(expected, actual, "Adding multiple numbers with one delimiter failed.");
        }

        [TestMethod()]
        public void TestAdd_multiple_numbers_with_Star_Delimiter()
        {
            CalcChallenge cc = new CalcChallenge();
            string input = "[***]\n11***22***33";
            int expected = 66; // 11 + 22 + 33 = 66
            int actual = cc.Add_multiple_numbers_with_Star_Delimiter(input);
            Assert.AreEqual(expected, actual, "Adding multiple numbers with star delimiter failed.");
        }

        [TestMethod()]
        public void TestAdd_multiple_numbers_with_Multiple_Delimiter()
        {
            CalcChallenge cc = new CalcChallenge();
            string input = "[*][!!][r9r]\n11r9r22*33!!44";
            int expected = 110; // 11 + 22 + 33 + 44 = 110
            int actual = cc.Add_multiple_numbers_with_Multiple_Delimiter(input);
            Assert.AreEqual(expected, actual, "Adding multiple numbers with multiple delimiters failed.");
        }
    }
}