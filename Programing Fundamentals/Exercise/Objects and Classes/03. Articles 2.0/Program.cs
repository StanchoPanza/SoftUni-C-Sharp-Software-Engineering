using System;
using System.Collections.Generic;

namespace Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] newArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                
                string title = newArticle[0];
                string content = newArticle[1];
                string author = newArticle[2];

                Article article = new Article(title, content, author);

                articles.Add(article);

            }
            string input = Console.ReadLine();
            foreach (Article article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }

        }
    }
}
