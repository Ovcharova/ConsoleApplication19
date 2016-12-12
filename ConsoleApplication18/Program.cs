using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{

    class Program
    {

        static void Main(string[] args)
        {

            var articlesCollection = new List<Article>()
                {
                new Article()
                {
                    Index = 1,
                    Name = "How to cook",
                    Text = "For cooking ;skjgkjgkfjkssjksgjfhk",
                    Comment = "",
                    TimeComment = new DateTime()
                },
                new Article()
                {
                    Index = 2,
                    Name = "How to eat",
                    Text = "For eating ;skjgkjgkfjkssjksgjfhk",
                    Comment = "",
                    TimeComment = new DateTime()
                },
            };

            Console.WriteLine("Number of Article For read: ");
            string n;
            int numberArticle = Console.ReadLine.Parse(n);

            int numberArticle = -1;

            int i = -1;
            foreach (var item in articlesCollection)
            {
                i++;
                if (numberArticle == Article.Index)
                {
                    numberArticle = i;
                    break;
                }
                if (numberArticle == -1)
                {
                    Console.WriteLine("No such Article");
                    Console.Beep();
                    break;
                }
                Console.WriteLine(StringBilder.ToString());
            }
        }
    }
