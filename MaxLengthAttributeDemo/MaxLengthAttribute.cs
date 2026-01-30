using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.MaxLengthAttributeDemo
{
    // Problem Statement: Define a field-level attribute MaxLength(int value) that restricts the maximum length of a string field.

    [AttributeUsage(AttributeTargets.Field)]
    public class MaxLengthAttribute : Attribute
    {
        public int Length { get; }

        public MaxLengthAttribute(int length)
        {
            Length = length;
        }
    }
}