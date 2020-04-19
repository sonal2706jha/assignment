﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
   public class SubtractOperator

    {
        private double? _numericResult;
        private StringBuilder _stringResult;
        public SubtractOperator()
        {
        }


        //subtraction for 2 numeric nnumbers
        public object Evaluate(List<object> data)
        {

            object result;
            foreach (object value in data)
            {
                if (value.IsNumeric())
                {

                    if (_numericResult == null)
                        _numericResult = Convert.ToDouble(value);
                    else
                    {
                        _numericResult = _numericResult.Value - Convert.ToDouble(value);
                    }

                }

                else
                {
                    throw new ArgumentException($"Non numeric or string value encountered");
                }
            }

            if (_numericResult != null)
                result = _numericResult.Value;
            else
            {
                throw new ArgumentException($"Incorrect arguments encountered in {nameof(SubtractOperator)}");
            }
            return result;
        }
    }
}
