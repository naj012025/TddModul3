using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TddApi.Controllers;
using TddApi.Dto;
using TddApi.Services;
using XpTdd.Models;
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
                    "/api/player/gain-xp?amount=150",
                    content: null);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
