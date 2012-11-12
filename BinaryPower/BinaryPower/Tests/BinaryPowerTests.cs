using BinaryPower.Logic;
using NUnit.Framework;

namespace BinaryPower.Tests
{
    [TestFixture]
    class BinaryPowerTests
    {
        private BinaryPowerer powerer;

        [SetUp]
        public void Setup()
        {
            powerer = new BinaryPowerer();
        }

        [Test]
        public void Should_Return1_WhenEntered1_5_4()
        {
            const int baseValue = 1;
            const int index = 5;
            const int mod = 4;
            const int expected = 1;

            var result = powerer.Rize(baseValue, index, mod);

            Assert.That(result.Equals(expected));
        }

        [Test]
        public void Should_Return_8_WhenEntered_2_3_10()
        {
            const int baseValue = 2;
            const int index = 3;
            const int mod = 10;
            const int expected = 8;

            var result = powerer.Rize(baseValue, index, mod);

            Assert.That(result.Equals(expected));
        }

        [Test]
        public void Should_Return_3_WhenEntered_2_3_5()
        {
            const int baseValue = 2;
            const int index = 3;
            const int mod = 5;
            const int expected = 3;

            var result = powerer.Rize(baseValue, index, mod);

            Assert.That(result.Equals(expected));
        }

        [Test]
        public void Should_Return_0_WhenEntered_100000_1000000_1()
        {
            const int baseValue = 100000;
            const int index = 1000000;
            const int mod = 1;
            const int expected = 0;

            var result = powerer.Rize(baseValue, index, mod);

            Assert.That(result.Equals(expected));
        }

        [Test]
        public void Should_Return_4_WhenEntered_2_10_10()
        {
            const int baseValue = 2;
            const int index = 10;
            const int mod = 10;
            const int expected = 4;

            var result = powerer.Rize(baseValue, index, mod);

            Assert.That(result.Equals(expected));
        }

        [Test]
        public void Should_Return_4_WhenEntered_2_10_5()
        {
            const int baseValue = 2;
            const int index = 10;
            const int mod = 5;
            const int expected = 4;

            var result = powerer.Rize(baseValue, index, mod);

            Assert.That(result.Equals(expected));
        }
    }
}
