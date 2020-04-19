﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestProject;

namespace UnitTesting
{
    [TestClass]
   public class AddOperatorTest
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
            var addOperator = new AddOperator();
            //addOperator.Evaluate(list);
            // Assert
            Assert.IsTrue(Math.Abs(Convert.ToDouble(addOperator.Evaluate(list)) - Convert.ToDouble(info.expected)) < Tolerance);
        }

        [TestMethod]
        [DynamicData(nameof(GetStringValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_AddStirngArgs_ResultReturns((object[] operands, string expected) info)
        {
            // Arrange
            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                list.Add(operand);
            }
            // Act
            var addOperator = new AddOperator();
            //addOperator.Evaluate(list);
            // Assert
            Assert.AreEqual(addOperator.Evaluate(list), Convert.ToString(info.expected));
        }
        public static IEnumerable<object[]> GetFinityValueDataRow()
        {
            yield return new object[] { (Addition: new object[] { 0, 14 }, Expected: 14D) };
            yield return new object[] { (Addition: new object[] { 1, 1 }, Expected: 2D) };
            yield return new object[] { (Addition: new object[] { 17, -2 }, Expected: 15D) };
            yield return new object[] { (Addition: new object[] { -22, -11 }, Expected: -33D) };
            yield return new object[] { (Addition: new object[] { 12, 30.5 }, Expected: 42.5D) };
            yield return new object[] { (Addition: new object[] { 12.2, 22 }, Expected: 34.2D) };
            yield return new object[] { (Addition: new object[] { 20.65, 10.45 }, Expected: 31.1D) };
            yield return new object[] { (Addition: new object[] { 12.10, -3.5 }, Expected: 8.6) };
            yield return new object[] { (Addition: new object[] { -12.10, 3.5, }, Expected: -8.6) };
            yield return new object[] { (Addition: new object[] { 0.000000000000000000321, 0.000000000000000000003 }, Expected: 2.5202598881629844E-35D) };
            yield return new object[] { (Addition: new object[] { 1235349, 8, 3 }, Expected: 1235360D) };
            yield return new object[] { (Addition: new object[] { 1235349, 8, 3, 2 }, Expected: 1235362D) };
        }

        public static IEnumerable<object[]> GetStringValueDataRow()
        {
            yield return new object[] { (Addition: new object[] { "I", "J", "M", "G", "E" }, Expected: "IJMGE") };
            yield return new object[] { (Addition: new object[] { "u", "d", "c", "c", "F" }, Expected: "udccF") };
            yield return new object[] { (Addition: new object[] { "u", "D", "C", "c", "F" }, Expected: "uDCcF") };
        }

        public static IEnumerable<object[]> GetStringAndNumberValueDataRow()
        {
            yield return new object[] { (Addition: new object[] { "I", "J", "M", "G", "E", 3 }, Expected: "IJMGE") };
            yield return new object[] { (Addition: new object[] { "u", "d", "c", "c", "F", 0.56 }, Expected: "udccF") };
            yield return new object[] { (Addition: new object[] { "u", "D", "C", "c", "F", 5.6 }, Expected: "uDCcF") };
        }

        public static IEnumerable<object[]> GetPositiveInfinityValueDataRow()
        {
            yield return new object[] { new object[] { double.MaxValue, 9.985e307 } };
            yield return new object[] { new object[] { double.MaxValue, double.MaxValue } };
            yield return new object[] { new object[] { double.MaxValue, double.MaxValue, double.MaxValue } };
        }

        public static IEnumerable<object[]> GetNegativeInfinityValueDataRow()
        {
            yield return new object[] { new object[] { double.MinValue, -9.985e307 } };
            yield return new object[] { new object[] { double.MinValue, double.MinValue, double.MinValue } };
        }

    }
}
    
