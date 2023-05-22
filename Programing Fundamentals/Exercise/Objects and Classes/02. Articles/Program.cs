using System;

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

        public void Edit(string newData)
        {
            this.Content = newData;
        }
        public void ChangeAuthor(string newData)
        {
            this.Author = newData;
        }
        public void Rename(string newData)
        {
            this.Title = newData;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articles = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());


            Article article = new Article(articles[0], articles[1], articles[2]);


            for (int i = 0; i < n; i++)
            {

                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                
                
                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else 
                {
                    article.Rename(command[1]);    
                }
            }
            Console.WriteLine(article.ToString());

        }
    }
}
