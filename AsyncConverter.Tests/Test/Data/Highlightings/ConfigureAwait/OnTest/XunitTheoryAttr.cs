﻿using System;
using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    using Xunit;
    public class Class
    {
        [Theory]
        public async Task Test()
        {
            await Task.Delay(1000);
        }
    }
}

namespace Xunit
{
    public class TheoryAttribute : Attribute
    { }
}