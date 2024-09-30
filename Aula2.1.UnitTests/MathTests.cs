using System;
using System.Collections.Generic;
using Xunit;

namespace Aula2._1.Tests
{
    public class MathTests
    {
        [Fact]
        public void Fibonacci_Test()
        {
            Math math = new();
            var result = math.Fibonacci();
            Assert.NotNull(result);
        }

        [Fact]
        public void Fibonacci_Membrer_Count_Test()
        {
            var math = new Math();
            var result = math.Fibonacci();
            Assert.Equal(14, result.Count);
        }

        [Fact]
        public void Fibonacci_Membrers_Test()
        {
            var math = new Math();
            var result = math.Fibonacci();
            Assert.Equal(result, new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 });
        }

        [Fact]
        public void Is_Fibonacci_Test()
        {
            var math = new Math();
            Assert.True(math.IsFibonacci(5));
        }

        [Fact]
        public void Is_NotFibonacci_Test()
        {
            var math = new Math();
            Assert.False(math.IsFibonacci(4));
        }
    }
}
