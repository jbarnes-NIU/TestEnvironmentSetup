using System;
using Xunit;

namespace TestEnvironmentSetup.Tests
{
    public class SampleUnitTests
    {
        [Fact]
        public void FailingTest()
        {
            Assert.True(false);
        }

        [Fact]
        public void PassingTest()
        {
            Assert.True(true);
        }
    }
}
