using NUnit.Framework;
using System;
using System.Linq;

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

        [Test]
        public void Test_When_input_s1_is_aretheyhere_and_s2_is_yestheyarehere_should_be_sort_to_aehrsty()
        {
            Assert.AreEqual("aehrsty", TwoToOneSolution.Longest("aretheyhere", "yestheyarehere"));
        }

        [Test]
        public void Test_When_input_s1_is_loopingisfunbutdangerous_and_s2_is_lessdangerousthancoding_should_be_sort_to_abcdefghilnoprstu()
        {
            Assert.AreEqual("abcdefghilnoprstu", TwoToOneSolution.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
        }

        [Test]
        public void Test_When_input_s1_is_inmanylanguages_and_s2_is_theresapairoffunctions_should_be_sort_to_acefghilmnoprstuy()
        {
            Assert.AreEqual("acefghilmnoprstuy", TwoToOneSolution.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }

    public static class TwoToOneSolution
    {
        public static string Longest(string s1, string s2)
        {
            var result = (s1 + s2).ToArray();
            Array.Sort(result);
            return String.Join("", result.Distinct());
        }
    }
}
