using Frontend;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FrontendTest
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;

        public IntegrationTests(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }

        [Fact]
        public async Task MainPageLoadsSuccessfully()
        {
            var responseMessage = await factory.CreateClient().GetAsync("/");

            var a = responseMessage.EnsureSuccessStatusCode();

            Assert.Equal(expected: a, actual: responseMessage);
        }

        [Fact]
        public void Abc()
        {
            int a = 1;
            int b = 2;
            Assert.Equal(a,b);
        }
    }
}
