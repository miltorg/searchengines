using System;
using System.Text.RegularExpressions;
using System.Net;


class Example
{
    static void Main()
    {
     string input=new WebClient().DownloadString("http://bar-navig.yandex.ru/u?ver=2&url=http://prohorov-andrej.ru&show=1");
 //Console.WriteLine (input);

        string pattern = @"(value=....)";
        Regex regex = new Regex(pattern);

        // Достигаем того же результата что и в предыдущем примере,
        // используя метод Regex.Matches() возвращающий MatchCollection
        foreach (Match match in regex.Matches(input))
        {
            Console.WriteLine(match.Groups[1].Value);
        }
    }
}