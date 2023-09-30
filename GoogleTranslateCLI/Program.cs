
using CommandLine;
namespace GoogleTranslateCLI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            ParserResult<Options> result = Parser.Default.ParseArguments<Options>(args);
            Options options = result.Value;
            string sourceLanguage = options.sourceLanguage;
            string targetLanguage = options.targetLanguage;
            string firstQuery = options.query;
            IEnumerable<string> remainQuery = options.remainingQuery;
            string query = firstQuery + String.Join(" ", remainQuery);
            
            string url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                sourceLanguage, targetLanguage, Uri.EscapeUriString(query));

            using (HttpClient client = new HttpClient()) 
            {
                var response = await client.GetStringAsync(url);
                int first = response.IndexOf('"');
                int second = response.Substring(first + 1).IndexOf('"');
                string translation = response.Substring(first + 1, second);
                Console.WriteLine(">>>>" + translation);
            }
        }
    }
}
