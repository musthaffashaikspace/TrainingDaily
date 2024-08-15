using MVCAPP.Models;

namespace MVCAPP.Services
{
    public class CategoryService
    {
        private readonly HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            var query = new
            {
                query = "{\r\n    categories{\r\n        categoryid\r\n        categoryName\r\n    }\r\n}"
            };
            var response = await _httpClient.PostAsJsonAsync("/gateway/category", query);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new Exception($"Request failed with status {response.StatusCode}. Response: {errorContent}");
            }

            var data = await response.Content.ReadFromJsonAsync<GraphQLResponse>();
            return data.Data.Categories;
        }
    }
}
