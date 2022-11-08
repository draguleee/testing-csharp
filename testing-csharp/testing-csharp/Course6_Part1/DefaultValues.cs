using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course6_Part1
{
    public class DefaultValues
    {
        // Value types
        public bool BooleanValue;
        public byte ByteValue;
        public char CharValue;
        public decimal DecimalValue;
        public double DoubleValue;
        public float FloatValue;
        public int IntValue;
        public uint UIntValue;  
        public long LongValue;
        public ulong ULongValue;
        public sbyte SByteValue;
        public short ShortValue;
        public ushort UShortValue;
        public string StringValue;

        // Method to show the default value of the variables
        public void ShowDefaultValues()
        {
            Console.WriteLine("Default value for bool: " + BooleanValue);
            Console.WriteLine("Default value for byte: " + ByteValue);
            Console.WriteLine("Default value for char: " + CharValue);
            Console.WriteLine("Default value for decimal: " + DecimalValue);
            Console.WriteLine("Default value for double: " + DoubleValue);
            Console.WriteLine("Default value for float: " + FloatValue);
            Console.WriteLine("Default value for int: " + IntValue);
            Console.WriteLine("Default value for uint: " + UIntValue);
            Console.WriteLine("Default value for long: " + LongValue);
            Console.WriteLine("Default value for ulong: " + ULongValue);
            Console.WriteLine("Default value for sbyte: " + SByteValue);
            Console.WriteLine("Default value for short: " + ShortValue);
            Console.WriteLine("Default value for ushort: " + UShortValue);
            Console.WriteLine("Default value for string: " + StringValue);
        }

    }
}
