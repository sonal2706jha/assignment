using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestProject;

namespace UnitTesting
{
    [TestClass]
    public class EqualOperatorTest
    {
        //comparing integers
        [TestMethod]
        [DynamicData(nameof(GetFinityValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_EqualPositiveNegativeArgs_ResultReturns((object[] operands, bool expected) info)
        {
            // Arrange

            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                list.Add(operand);
            }
            // Act
            var equalOperator = new EqualOperator();
            //addOperator.Evaluate(list);
            // Assert
            Assert.AreEqual(equalOperator.Evaluate(list), info.expected);
        }


        //comparing string values
        [TestMethod]
        [DynamicData(nameof(GetStringValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_EqualStirngArgs_ResultReturns((object[] operands, bool expected) info)
        {
            // Arrange
            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                list.Add(operand);
            }
            // Act
            var equalOperator = new EqualOperator();
            //addOperator.Evaluate(list);
            // Assert
            Assert.AreEqual(equalOperator.Evaluate(list), info.expected);
        }

        public static IEnumerable<object[]> GetFinityValueDataRow()
        {
            yield return new object[] { (EqualsCheck: new object[] { 0, 7 }, Expected: false) };
            yield return new object[] { (EqualsCheck: new object[] { 1, 1 }, Expected: true) };
            yield return new object[] { (EqualsCheck: new object[] { 19, -2 }, Expected: false) };
            yield return new object[] { (EqualsCheck: new object[] { -22, -71 }, Expected: false) };
            yield return new object[] { (EqualsCheck: new object[] { 15, 30.5 }, Expected: false) };
            yield return new object[] { (EqualsCheck: new object[] { 16.2, 16.2 }, Expected: true) };
            yield return new object[] { (EqualsCheck: new object[] { 25.65, 10.45 }, Expected: false) };
            yield return new object[] { (EqualsCheck: new object[] { -4.5, -4.5 }, Expected: true) };
            yield return new object[] { (EqualsCheck: new object[] { -18.10, 3.5, }, Expected: false) };
            yield return new object[] { (EqualsCheck: new object[] { 0.000000000000000000721, 0.000000000000000000721 }, Expected: true) };
            yield return new object[] { (EqualsCheck: new object[] { 1235349, 8, 3 }, Expected: false) };
            yield return new object[] { (EqualsCheck: new object[] { 1235349, 1235349, 1235349, 1235349 }, Expected: true) };
        }

        public static IEnumerable<object[]> GetStringValueDataRow()
        {
            yield return new object[] { (EqualsCheck: new object[] { "P", "Q", "R", "S", "T" }, Expected: false) };
            yield return new object[] { (EqualsCheck: new object[] { "u", "D", "C", "c", "F" }, Expected: false) };
        }

    }
}
    

