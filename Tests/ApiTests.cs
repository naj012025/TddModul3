using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http.Json;
using TddApi.Dto;
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

        [Fact]
        public async Task GainXp_With150Xp_ReturnsLevel2and50RemainingXp()
        {
            //Act
            HttpResponseMessage response =
                await _client.PostAsync(
                    "/api/player/gain-xp?amount=150",
                    content: null);

            PlayerResponse? player =
                // no jason yet ?
                await response.Content.ReadFromJsonAsync<PlayerResponse>();
            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(player);
            Assert.Equal(2, player.Level);// Asserts level gain to lvl 2.
            Assert.Equal(50, player.Xp);// asseerts 50 leftover Xp

        }
    }
}
