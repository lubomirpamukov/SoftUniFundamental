namespace _03._Articles
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = cmdArgs[0].Trim();
                string content = cmdArgs[1].Trim();
                string author = cmdArgs[2].Trim();

                Article article = new Article(title,content,author);

                articles.Add(article);
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }

        public class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }


}