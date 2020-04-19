using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestProject;

namespace UnitTesting
{
    [TestClass]
   public class MultiplicationOperatorTest
    {
        public const double Tolerance = 0.0000001;

        //multiply 2 postive or negative numbers
        [TestMethod]
        [DynamicData(nameof(GetFinityValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_MultiplyPositiveNegativeArgs_ResultReturns((object[] operands, double expected) info)
        {
            // Arrange

            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                list.Add(operand);
            }
            // Act
            var multiplyOperator = new MultiplicationOperator();

            // Assert
            Assert.IsTrue(Math.Abs(Convert.ToDouble(multiplyOperator.Evaluate(list)) - Convert.ToDouble(info.expected)) < Tolerance);
        }



        public static IEnumerable<object[]> GetFinityValueDataRow()
        {
            yield return new object[] { (Multiply: new object[] { 0, 25 }, Expected: 0D) };
            yield return new object[] { (Multiply: new object[] { 0, -25 }, Expected: 0D) };
            yield return new object[] { (Multiply: new object[] { 1, 1 }, Expected: 1D) };
            yield return new object[] { (Multiply: new object[] { 18, -2 }, Expected: -36D) };
            yield return new object[] { (Multiply: new object[] { -9, -8 }, Expected: 72D) };
            yield return new object[] { (Multiply: new object[] { 14, 20.5 }, Expected: 287D) };
            yield return new object[] { (Multiply: new object[] { 12.2, 22 }, Expected: 268.4D) };
            yield return new object[] { (Multiply: new object[] { 30.65, 20.45 }, Expected: 626.7925D) };
            yield return new object[] { (Multiply: new object[] { -12.10, 3.5 }, Expected: -42.35D) };
            yield return new object[] { (Multiply: new object[] { -12.10, -3.5, }, Expected: 42.35D) };
            yield return new object[] { (Multiply: new object[] { 0.00000000000000000000123, 0.0000000000000000000023 }, Expected: 2.829E-42D) };
            yield return new object[] { (Multiply: new object[] { 1235349, 8, 3 }, Expected: 29648376D) };
            yield return new object[] { (Multiply: new object[] { 1235349, 8, 3, 2 }, Expected: 59296752D) };
        }




    }
}
    