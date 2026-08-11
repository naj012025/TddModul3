using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http.Json;
using TddApi.Dto;
namespace Tests
{
    public class ApiTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        //Naming rule Given, When , Then and inside the brackets i do,
        //Arrange,Act,Assert. with theory its Inlinedata.

        public ApiTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();

        }

        [Fact]
        public async Task GainXp_ReturnSuccess()
        {
            GainXpRequest request = new()
            {
                Amount = 150
            };

            HttpResponseMessage response =
                await _client.PostAsJsonAsync(
                    "/api/player/gain-xp",
                    request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GainXp_With150Xp_ReturnsLevel2and50RemainingXp()
        {
            //Act
            GainXpRequest request = new()
            {
                Amount = 150
            };
            HttpResponseMessage response =
                await _client.PostAsJsonAsync(
                    "/api/player/gain-xp",
                    request);

            PlayerResponse? player =
                await response.Content.ReadFromJsonAsync<PlayerResponse>();
            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(player);
            Assert.Equal(2, player.Level);// Asserts level gain to lvl 2.
            Assert.Equal(50, player.Xp);// asseerts 50 leftover Xp

        }

        [Fact]
        public async Task GetGoblin_WhenGoblinExist_Return200Ok()
        {
            //Arrange
            //Nothing to arrange
            //Act
            HttpResponseMessage response =
                await _client.GetAsync("/api/goblin");
            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetGoblin_WhenGoblinDoesNotExist_Return404NotFound()
        {
            //Arrange
            int goblinId = 999;
            //Act
            HttpResponseMessage response =
                await _client.GetAsync("/api/goblin");
            //Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}





