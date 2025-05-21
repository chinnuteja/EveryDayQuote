using System.Text.Json;
using RandomQuoteAPI.Models;

namespace RandomQuoteAPI.Services
{
    public interface IQuoteService
    {
        Quote GetRandomQuote();
    }

    public class QuoteService : IQuoteService
    {
        private readonly List<Quote> _quotes;
        private readonly Random _rng = new();

        public QuoteService(IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "quotes.json");
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Quotes file not found", filePath);

            var json = File.ReadAllText(filePath);
            _quotes = JsonSerializer.Deserialize<List<Quote>>(json)
                      ?? new List<Quote>();
        }

        public Quote GetRandomQuote()
        {
            if (_quotes.Count == 0)
                return new Quote { Id = 0, Text = "No quotes available.", Author = "System" };

            var idx = _rng.Next(_quotes.Count);
            return _quotes[idx];
        }
    }
}
