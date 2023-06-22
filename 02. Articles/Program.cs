namespace _02._Articles
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries); // reading array of strings

            Article article = new Article(data[0], data[1], data[2]); // initializing new  object with the given data

            int n = int.Parse(Console.ReadLine()); // taking number of changes

            for (int i = 0; i < n; i++) // loop that changes the given article each itteration
            {
                string[] cmdArgs = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries); // taking data from the console in array of strings
                string command = cmdArgs[0].Trim(); // saving data in new variable and triming the white spaces
                string newData = cmdArgs[1].Trim();// saving data in new variable and triming white space 

                if (command == "Edit") // if command is edit
                {
                    article.EditContent(newData); // calling a method that edits the content of the article
                }
                else if (command == "ChangeAuthor") // if command is change author
                {
                    article.ChangeAuthor(newData); // calling a method that changes author
                }
                else if (command == "Rename") // if command is rename
                {
                    article.NewTitle(newData); // calling a metod that changes the title
                }
            }

            Console.WriteLine(article); // printing the new article
        }

        public class Article // declaring article class
        {
            public Article(string title, string content, string author) // article constructor that takes title content and author in string format
            {
                this.Title = title; // saving the title data in the class property
                this.Content = content; // saving the content data in the content property 
                this.Author = author; // saving the author data in the author property
            }
            public string Title { get; set; } // declaring Title property

            public string Content { get; set; } // declaring Content property

            public string Author { get; set; } // declaring Author property

            public string EditContent(string newData) // declaring method that changes the content with new content
            {
                return this.Content = newData; // returns the changed content
            }

            public string ChangeAuthor(string newData) // declaring a method that changes the author
            {
                return this.Author = newData; //returning the new author
            }

            public string NewTitle(string newData) //declaring am etohd that changes the title
            {
                return this.Title = newData; // returning the new title
            }

            public override string ToString() //over writing the ToString method to do different thing
            {
                return $"{Title} - {Content}: {Author}"; // new ToString returns
            }
        }
    }

   
}