using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace CodilityStarter
{
    public class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            return 0;
        }

        public static IEnumerable<object[]> Test1Data => new[]
        {
            new object[] {new[] {0, 0, 0}},
            new object[] {new[] {0, 0, 0}},
        };

        [Theory]
        [MemberData(nameof(Test1Data))]
        public void Test1_Description(int[] input)
        {
            var solution = new Solution();
            var result = solution.solution(input);

            var expected = 0;
            result.ShouldBeEquivalentTo(expected);
        }

        [Fact]
        public void Test2_Description()
        {
            var solution = new Solution();
            var input = new int[] {};
            var result = solution.solution(input);

            var expected = 0;
            result.ShouldBeEquivalentTo(expected);
        }
    }
}