﻿using Atata;
using Xunit;
using Xunit.Abstractions;

namespace AtataSamples.Xunit
{
    public class SampleTests : UITestFixture
    {
        /// <summary>
        /// It is required to define constructor with argument of ITestOutputHelper type for Xunit log output.
        /// </summary>
        /// <param name="output">The output.</param>
        public SampleTests(ITestOutputHelper output)
            : base(output)
        {
        }

        /// <summary>
        /// Simple test approach when you don't need to add exception/error information to the log. For example, when you use Visual Studio or CI system to view the log, as exception is displayed there any way.
        /// </summary>
        [Fact]
        public void XUnitTest()
        {
            Go.To<HomePage>().
               Header.Should.Equal("Atata Sample App");
        }

        /// <summary>
        /// Use such approach with Run method when you need to add exception/error information to the log. It is needed if you log to file or other external source. It is not required when you just use ITestOutputHelper as a single log target.
        /// </summary>
        [Fact]
        public void XUnitTestWithExceptionLogging()
        {
            Run(() =>
            {
                Go.To<HomePage>().
                    Header.Should.Equal("Atata Sample App");
                ////Header.Should.Equal("Unknown Title");
            });
        }
    }
}
