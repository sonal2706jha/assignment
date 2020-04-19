﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    public class AddOperator
    {

        private double? _numericResult;
        private StringBuilder _stringResult;
        public AddOperator()
        {
        }

        public object Evaluate(List<object> data)
        {
            bool stringFound = false, numericFound = false;
            object result;
            foreach (object value in data)
            {
                if (value.IsNumeric())
                {

                    if (_numericResult == null)
                        _numericResult = 0.0;
                    _numericResult = _numericResult.Value + Convert.ToDouble(value);
                }
                else if (value.IsString())
                {
                    if (_stringResult == null)
                        _stringResult = new StringBuilder();
                    _stringResult.Append(value);
                }
                else
                {
                    throw new ArgumentException($"Non numeric or string value encountered");
                }
            }

            if (_numericResult != null)
                result = _numericResult.Value;
            else if (_stringResult != null)
            {
                result = _stringResult.ToString();
            }
            else
            {
                throw new ArgumentException($"Incorrect arguments encountered in {nameof(AddOperator)}");
            }
            return result;
        }
    }
}

