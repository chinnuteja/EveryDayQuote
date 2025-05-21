using Microsoft.AspNetCore.Mvc;
using RandomQuoteAPI.Models;
using RandomQuoteAPI.Services;

namespace RandomQuoteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        private readonly IQuoteService _quoteService;

        public QuotesController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        /// <summary>
        /// Returns a random quote loaded from quotes.json.
        /// </summary>
        [HttpGet("random")]
        public ActionResult<Quote> GetRandom()
        {
            var quote = _quoteService.GetRandomQuote();
            return Ok(quote);
        }
    }
}
