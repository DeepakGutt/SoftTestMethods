using NUnit.Framework;
using SoftTestMeth;
namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Equilateral_Triangle_Test()     //This test method will check the Triangle will be Equilateral or not with input values that can create an Equilateral Triangle
        {
            string ExpectedResult= "Equilateral";
            string ActualResult=TriangleSolver.Analyze(10,10,10);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void Scalene_Triangle_Test()       //This unit test will check the Triangle will be Scalene or not with input values that can create a Scalene Triangle
        {
            string ExpectedResult = "Scalene";
            string ActualResult = TriangleSolver.Analyze(3,5,4);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void Isosceles_Triangle_Test()    //This unit test will check the Triangle will be Isosceles or not with input values that can create a Isosceles Triangle               
        {
            string ExpectedResult = "Isosceles";
            string ActualResult = TriangleSolver.Analyze(2, 2, 1);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void Invalid_Triangle_Sides_Test()     //This unit test will check the result will be invalid Input Values or not with input values(0,0,0) that can not create a triangle
        { 
            string ExpectedResult = "Invalid Sides! Cannot form a triangle";
            string ActualResult = TriangleSolver.Analyze(0, 0, 0);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void Test_One_Negative_Side()      //This unit test will check  the output with one negative and two positive sides
        {
            string ExpectedResult = "Invalid Sides! Cannot form a triangle";
            string ActualResult = TriangleSolver.Analyze(-1, 3, 5);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void Test_Two_Negative_Sides()     //This unit test will check the output with two negative side 
        {
            string ExpectedResult = "Invalid Sides! Cannot form a triangle";
            string ActualResult = TriangleSolver.Analyze(-1, 1, -1);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void Test_All_Negative_Sides()     //This unit test will check the output with all negative side
        {
            string ExpectedResult = "Invalid Sides! Cannot form a triangle";
            string ActualResult = TriangleSolver.Analyze(-1, -1, -1);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void Test_Isosceles()   //This unit test will check the result is Isosceles Triangle or not when First and Third Side is Equal and second is different
        {
            string ExpectedResult = "Isosceles";
            string ActualResult = TriangleSolver.Analyze(4, 3, 4);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }










    }
}