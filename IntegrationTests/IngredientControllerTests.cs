using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MenuApp.InventoryService;
using MenuApp.InventoryService.Logic.Entity;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace IntegrationTests
{
    
    public class IngredientControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private HttpClient _client { get; set; }
        
        public IngredientControllerTests(WebApplicationFactory<Startup> fixture)
        {
            _client = fixture.CreateClient();
        }
        
        [Theory]
        [InlineData("/Ingredient/GetAll")]
        public async Task DoesTheGetEndPointExist(string url)
        {
            var response = await _client.GetAsync(url);
            
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            
            Assert.Equal("application/json; charset=utf-8", 
                response.Content.Headers.ContentType.ToString());
        }
        
        [Fact]
        public async Task DoesThePostEndPointExist()
        {
            var response = await _client.PostAsync("/Ingredient/Create", 
                new StringContent(
                    JsonConvert.SerializeObject(new Ingredient()
            {
                Name = "Risotto",
                AmountNeeded = 6
            }), 
                    Encoding.UTF8, 
                    "application/json"));

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Fact]
        public async Task DoesThePostMultipleEndPointExist()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient()
            {
                Name = "Risotto",
                AmountNeeded = 6
            });
            ingredients.Add(new Ingredient()
            {
                Name = "Spaghetti",
                AmountNeeded = 12
            });
            var response = await _client.PostAsync("/Ingredient/CreateMultiple", 
                new StringContent(
                    JsonConvert.SerializeObject(ingredients), 
                    Encoding.UTF8, 
                    "application/json"));

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData("/Ingredient/Update")]
        public async Task DoesThePutEndPointExist(string url)
        {
            var response = await _client.PutAsync(url, 
                new StringContent(
                    JsonConvert.SerializeObject(new Ingredient()
                    {
                        
                        Name = "brood",
                        AmountNeeded = 567
                    }), 
                    Encoding.UTF8, 
                    "application/json"));

            Assert.Equal("application/json; charset=utf-8", 
                response.Content.Headers.ContentType.ToString());
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        
        [Theory]
        [InlineData("/Ingredient/Delete")]
        public async Task DoesTheDeleteEndPointExist(string url)
        {
            Ingredient ingredient = new Ingredient()
            {
                Id = Guid.Parse("08d93615-6666-4ac1-8dab-86be55fe837a"),
            };
            
            var request = new HttpRequestMessage(HttpMethod.Delete, url);
            request.Content = new StringContent(JsonConvert.SerializeObject(ingredient), Encoding.UTF8, "application/json");
            await _client.SendAsync(request);

            
            Assert.Equal("application/json; charset=utf-8", request.Content.Headers.ContentType.ToString());
        }
    }
}