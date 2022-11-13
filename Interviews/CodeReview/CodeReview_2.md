It is required to implement a console application for counting words on a web page.
- The input takes a string with the URL address of the page.
- The application should count the number of words on this page.
- The result should be logged to a file and console.
- The solution will be supplemented with new requirements over time and the application will evolve.

```cs
public class ContentParser : IParser, IRequestManager
    {
        private ILogger Logger;

        public ContentParser(ILogger _logger)
        {
            Logger = _logger;
        }

        public void Parse(string url)
        {
            try
            {
                Logger.Log(new LogMessage { Message = String.Format("Processing address {0}", url)});
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (String.IsNullOrWhiteSpace(response.CharacterSet))
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                    string data = readStream.ReadToEnd();

                    data = Regex.Replace(data, @"<script[^>]*>[\s\S]*?</script>", string.Empty);
                    data = Regex.Replace(data, @"<style[^>]*>[\s\S]*?</style>", string.Empty);
                    data = Regex.Replace(data, @"<[^>]*>", string.Empty).ToUpper();

                    char[] delimiterChars = { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t' };
                    string[] words = data.Split(delimiterChars);
                    var result = words.GroupBy(x => x)
                              .Select(x => new { Word = x.Key, Frequency = x.Count() })
                              .Where(x => x.Word.Length > 0)
                              .OrderByDescending(x => x.Frequency);

                    Logger.Log(new LogMessage { Message = String.Format("Address {0} was processed. Processing result:", url) });
                    string msg;
                    foreach (var item in result)
                    {
                        msg = String.Format("Word: {0}\tThe number of repetitions: {1}", item.Word, item.Frequency);
                        Console.WriteLine(msg);
                        Logger.Log(new LogMessage { Message = msg });
                    }
                    Console.ReadKey();
                    response.Close();
                    readStream.Close();
                }
                else
                    Logger.Log(new LogMessage { Message = String.Format("Couldn't process address {0}. " +
                                                                            "Try again later.", url) });
                
            }
            catch (Exception ex)
            {
                Logger.Log(new LogMessage{Message = String.Format("Processing error for address {0}", url), Exception = ex });
            }
        }
	
	
    }
```