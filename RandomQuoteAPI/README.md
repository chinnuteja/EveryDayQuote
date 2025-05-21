# RandomQuoteAPI

A simple ASP.NET Core 8 Web API that returns random quotes loaded from a JSON file.

## Getting Started

1. **Prerequisites**: [.NET 8 SDK](https://dotnet.microsoft.com/download)
2. **Clone this repository**
3. **Ensure `quotes.json` is copied to the output directory (via project file or manual copy).**
4. **In the project folder, run:**
   ```bash
   dotnet restore
   dotnet run
   ```

5. **Navigate to `https://localhost:5001/swagger` to explore the API.**

## Endpoints

* `GET /api/quotes/random` : Returns a random quote.

## Example Response

```json
{
  "id": 7,
  "text": "The only way to do great work is to love what you do.",
  "author": "Steve Jobs"
}
