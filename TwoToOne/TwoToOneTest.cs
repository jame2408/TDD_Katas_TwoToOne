﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoToOne
{
    [TestFixture]
    public class TwoToOneTest
    {
        [Test]
        public void Test_When_input_s1_is_a_and_s2_is_a_should_be_a()
        {
            Assert.AreEqual("a", TwoToOneSolution.Longest("a", "a"));
        }

        [Test]
        public void Test_When_input_s1_is_a_and_s2_is_b_should_be_ab()
        {
            Assert.AreEqual("ab", TwoToOneSolution.Longest("a", "b"));
        }

        [Test]
        public void Test_When_input_s1_is_b_and_s2_is_a_should_be_sort_to_ab()
        {
            Assert.AreEqual("ab", TwoToOneSolution.Longest("b", "a"));
        }
    }

    public static class TwoToOneSolution
    {
        public static string Longest(string s1, string s2)
        {
            return s1 == s2 ? s1 : (s1 + s2);
        }
    }
}
