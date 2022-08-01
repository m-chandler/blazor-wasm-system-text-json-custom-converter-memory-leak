using System.Text.Json;
using BlazorApp1.Converters;
using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class JsonDeserialiserLooper
    {
        public async Task Start()
        {
            while (true)
            {
                var deserialised = JsonSerializer.Deserialize<TestModel>("{}", new JsonSerializerOptions
                {
                    Converters = { new CustomJsonConverter() }
                });
                await Task.Delay(10);
            }
        }
    }
}
