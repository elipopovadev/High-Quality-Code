using System.Text.RegularExpressions;

namespace Interpreter
{
   public class Order
    {
        // Grammar Representation
        const string optionalSpase = " ?";
        const string qty = "x(?<qty>\\d+)" + optionalSpase;
        const string product = "'(?<product>[\\w ]+)'" + optionalSpase;
        const string source = "from (?<source>\\w+)";
        const string orderCommand = "order" + optionalSpase + qty + product + source;
        static Regex regex = new Regex(orderCommand); // create regex

        public Order(int qty, string product,string source)
        {
            this.Qty = qty;
            this.Product = product;
            this.Source = source;
        }

        public int Qty { get; }
        public string Product { get; }
        public string Source { get; }

        // Interpreter
        public static string Parse(string command)
        {
            var match = regex.Match(command);
            if (!match.Success)
            {
                return null;
            }

            var qty = int.Parse(match.Groups["qty"].Value);
            var product = match.Groups["product"].Value;
            var source = match.Groups["source"].Value;

            return $"product: {product}, quantity: {qty}, source: {source}";
        }
    }
}
