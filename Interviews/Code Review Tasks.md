# Code Review

1. Do code review, optimize and say O(n):

```cs
public static class MyLinq
{
    public static IEnumerable<T> Reverse<T>(this IEnumerable<T> source)
    {
        var result = new List<T>();
        foreach (var item in source)
        {
            result.Insert(0, item);
        }
 
        return result;
    }
 
 
    public static IEnumerable<T> Except<T>(this IEnumerable<T> source, T[] except)
    {
        foreach (var item in source)
        {
            if (Array.FindIndex(except, i => item.Equals(i)) != -1)
                continue;
 
            yield return item;
        }
    }
 
 
    public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source)
    {
        var result = new List<T>();
 
        foreach (var item in source)
        {
            var contains = false;
            foreach (var e in result)
            {
                if (e.Equals(item))
                {
                    contains = true;
                    break;
                }
            }
 
            if (!contains)
                result.Add(item);
        }
 
        return result;
    }
}
```



2. Необходимо реализовать консольное приложение для подсчета слов на веб странице.
На входе принимается строка с url адресом страницы. Приложение должно посчитать кол-во слов на этой странице. 
Результат логировать в файл и выводить в консоль.
Данная бизнес-задача со временем будет дополняться новыми требованиями и приложение будет развиваться.

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
                Logger.Log(new LogMessage { Message = String.Format("Обработка адреса {0}", url)});
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

                    Logger.Log(new LogMessage { Message = String.Format("Обработка адреса {0} завершена. Результаты обработки:", url) });
                    string msg;
                    foreach (var item in result)
                    {
                        msg = String.Format("Слово: {0}\tКоличество повторов: {1}", item.Word, item.Frequency);
                        Console.WriteLine(msg);
                        Logger.Log(new LogMessage { Message = msg });
                    }
                    Console.ReadKey();
                    response.Close();
                    readStream.Close();
                }
                else
                    Logger.Log(new LogMessage { Message = String.Format("Не удалось обработать адрес {0}. " +
                                                                            "Попробуйте выполнить запрос позднее.", url) });
                
            }
            catch (Exception ex)
            {
                Logger.Log(new LogMessage{Message = String.Format("Ошибка при обработке адреса {0}", url), Exception = ex });
            }
        }
	
	
    }
```
