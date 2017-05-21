﻿using System;
using BanKai.Basic.Common;
using Xunit;

namespace BanKai.Basic
{
    public class NestedTypes
    {
        [Fact]
        public void should_connect_with_plus_sign_when_get_type_of_nested_class()
        {
            Type typeOfNestedType = typeof(NestedTypeDemoClass.NestedType);
            
            string fullName = typeOfNestedType.FullName;

            // correct the value of expectedFullName to fix the test.
            const string expectedFullName = "BanKai.Basic.Common.NestedTypeDemoClass+NestedType";

            Assert.Equal(expectedFullName, fullName);
        }
    }
}