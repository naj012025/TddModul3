using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TddApi;
using Xunit;
namespace Tests
{
    public class ApiTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public ApiTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();

        }

        [Fact]
        public async Task GainXp_ReturnSuccess()
        {
            HttpResponseMessage response =
                await _client.PostAsync(
                    "/TddApi/players/gain-xp?amount=150",
                    content: null);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
