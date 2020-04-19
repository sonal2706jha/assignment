using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestProject;

namespace UnitTesting
{
    [TestClass]
   public class SubtractOperatorTest
    {
        public const double Tolerance = 0.0000001;
        [TestMethod]
        [DynamicData(nameof(GetFinityValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_AddPositiveNegativeArgs_ResultReturns((object[] operands, double expected) info)
        {
            // Arrange

            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                list.Add(operand);
            }
            // Act
            var subtractOperator = new SubtractOperator();
            //addOperator.Evaluate(list);
            // Assert
            Assert.IsTrue(Math.Abs(Convert.ToDouble(subtractOperator.Evaluate(list)) - Convert.ToDouble(info.expected)) < Tolerance);
        }

        [TestMethod]
        [DynamicData(nameof(GetStringAndNumberValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_SubtractStringAndNumberArgs_ResultReturns((object[] operands, double expected) info)
        {
            // Arrange
            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                if (operand.IsNumeric())
                {
                    list.Add(operand);
                }
                else
                {
                    continue;
                }

            }
            // Act
            var subtractOperator = new SubtractOperator();
            //addOperator.Evaluate(list);
            // Assert
            Assert.IsTrue(Math.Abs(Convert.ToDouble(subtractOperator.Evaluate(list)) - Convert.ToDouble(info.expected)) < Tolerance);
            //Assert.AreEqual(minusOperator.Evaluate(list), Convert.ToString(info.expected));
        }

        public static IEnumerable<object[]> GetFinityValueDataRow()
        {
            yield return new object[] { (Subtraction: new object[] { 0, 18 }, Expected: -18D) };
            yield return new object[] { (Subtraction: new object[] { 7, 7 }, Expected: 0D) };
            yield return new object[] { (Subtraction: new object[] { 19, -2 }, Expected: 21D) };
            yield return new object[] { (Subtraction: new object[] { -22, -22 }, Expected: 0D) };
            yield return new object[] { (Subtraction: new object[] { 12, 40.5 }, Expected: -28.5D) };
            yield return new object[] { (Subtraction: new object[] { 12.2, 32 }, Expected: -19.8D) };
            yield return new object[] { (Subtraction: new object[] { 30.55, 10.45 }, Expected: 20.10D) };
            yield return new object[] { (Subtraction: new object[] { 12.20, -3.5 }, Expected: 15.70D) };
            yield return new object[] { (Subtraction: new object[] { -12.10, 3.8, }, Expected: -15.90D) };
            yield return new object[] { (Subtraction: new object[] { 0.000000000000000000321, 0.000000000000000000003 }, Expected: 3.18e-19D) };
            yield return new object[] { (Subtraction: new object[] { 1235349, 8, 3 }, Expected: 1235338D) };
            yield return new object[] { (Subtraction: new object[] { 1235349, 8, 3, 2 }, Expected: 1235336D) };
        }



        public static IEnumerable<object[]> GetStringAndNumberValueDataRow()
        {
            yield return new object[] { (Subtraction: new object[] { "P", "Q", "R", "S", "T", 7 }, Expected: 7D) };
            yield return new object[] { (Subtraction: new object[] { "A", "B", "C", "D", "E", 0.76 }, Expected: 0.76D) };
            yield return new object[] { (Subtraction: new object[] { "u", "D", "C", "c", "F", 5.7 }, Expected: 5.7D) };
        }





    }
}
