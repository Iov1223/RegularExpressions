using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void PrintPoem(string poem)
        {
            Console.WriteLine(poem);
        }
        static void PrintWord(string poem, string RE, string Letter, string Letter2)
        {
            Console.WriteLine(Letter);
            Regex regex = new Regex(RE, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(poem);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string poem = "Ну, что с того... Юрий Левитанский\n" +
                "Ну что с того, что я там был.\n" +
                "Я был давно, я все забыл.\n" +
                "Не помню дней, не помню дат.\n" +
                "И тех форсированных рек.\n" +
                "Я неопознанный солдат.\n" +
                "Я рядовой, я имярек.\n" +
                "Я меткой пули недолет.\n" +
                "Я лед кровавый в январе.\n" +
                "Я крепко впаян в этот лед.\n" +
                "Я в нем как мушка в янтаре.\n\n" +
                "Ну что с того, что я там был.\n" +
                "Я все забыл.Я все избыл.\n" +
                "Не помню дат, не помню дней,\n" +
                "названий вспомнить не могу.\n" +
                "Я топот загнанных коней.\n" +
                "Я хриплый окрик на бегу.\n" +
                "Я миг непрожитого дня,\n" +
                "я бой на дальнем рубеже.\n" +
                "Я пламя вечного огня,\n" +
                "и пламя гильзы в блиндаже.\n\n" +
                "Ну что с того, что я там был.\n" +
                "В том грозном быть или не быть.\n" +
                "Я это все почти забыл,\n" +
                "я это все хочу забыть.\n" +
                "Я не участвую в войне,\n" +
                "война участвует во мне.\n" +
                "И пламя вечного огня\n" +
                "горит на скулах у меня.\n\n" +
                "Уже меня не исключить\n" +
                "из этих лет, из той войны.\n" +
                "Уже меня не излечить\n" +
                "от тех снегов, от той зимы.\n" +
                "И с той зимой, и с той землей,\n" +
                "уже меня не разлучить.\n" +
                "До тех снегов, где вам уже\n" +
                "моих следов не различить.\n\n";
            PrintPoem(poem);
            Console.WriteLine("\nВведите букву кирилицы слова с которой нужно найти:");
            string Letter2 = Console.ReadLine();
            string RE = @"\w*" + Letter2 + "\\b";
            string Letter = "Все слова содержащие букву \"" + Letter2 + "\":";
            PrintWord(poem, RE, Letter, Letter2);
            Console.WriteLine("\nВведите букву кирилицы на которую оканчиваются слова:");
            Letter2 = Console.ReadLine();
            RE = @"\w*" + Letter2 + "\\b";
            Letter = "Все слова оканчивающиеся на букву \"" + Letter2 + "\":";
            PrintWord(poem, RE, Letter, Letter2);
            
        }
    }
}
