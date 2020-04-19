using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PATTERNS.NET.Structural.Adapter
{
    public class Quote : IQuote
    {
        private readonly List<string> quotesCollection = new List<string>();

        protected void FindAndSaveQuote(string text, int offset, int count)
        {
            var wordsInPage = text.Split(" ");
            var quoteSegment = new ArraySegment<string>(wordsInPage, offset, count);
            
            var quote = new StringBuilder();
            quote.Append("Quote: ");

            foreach (var word in quoteSegment.ToList<string>()) {
                quote.Append(word);
                quote.Append(" ");
            }

            Save(quote.ToString());
        }

        public void Save(string quote)
        {
            quotesCollection.Add(quote);
        }

        public void PrintAllQuotes()
        {
            foreach (var quote in quotesCollection) {
                Console.WriteLine(quote);
            }
        }
    }
}
