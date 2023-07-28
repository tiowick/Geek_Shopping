using System.Net.Http.Headers;
using System.Text.Json;

namespace GeekShopping.web.Utils
{
    public static class HttpClientExtensions
    {
        private static MediaTypeHeaderValue contentType = MediaTypeHeaderValue.Parse("application/json");
        public static async Task<T> ReadContentTAs<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode) throw new ApplicationException(
                $"Something went wrong calling Api!: " +
                $"{response.ReasonPhrase}");

            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(dataAsString,
                new JsonSerializerOptions 
                {PropertyNameCaseInsensitive = true });
        }

        public static Task<HttpResponseMessage> PostAsJson<T>(this HttpClient httpClent, string url, T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return httpClent.PostAsync(url, content);
        }
        public static Task<HttpResponseMessage> PutAsJson<T>(this HttpClient httpClent, string url, T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return httpClent.PutAsync(url, content);
        }
    }
}
