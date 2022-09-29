using System.Collections;

namespace Exercise1
{
    public class Book : IBook
    {
        private string? isbn;
        private string? title;
        private string? author;
        private string? publisher;
        private int year;
        private ArrayList chapter = new ArrayList();
        public string? this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string?)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public string? Title { get => title; set { title = value; } }
        public string? Author { get => author; set { author = value; } }
        public string? Publisher { get => publisher; set { publisher = value; } }
        public string? ISBN { get => isbn; set { isbn = value; } }
        public int Year { get => year; set { year = value; } }


        public void Show()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Publisher: " + Publisher);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0}: {1}", i + 1, chapter[i]);
            Console.WriteLine("----------------------");
        }

        public void Input()
        {
            Console.Write("Title: ");
            Title = Console.ReadLine();

            Console.Write("Author: ");
            Author = Console.ReadLine();

            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();

            Console.Write("Year: ");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.Write("ISBN: ");
            ISBN = Console.ReadLine();

            string? str;
            do
            {
                str = Console.ReadLine();
                if (str?.Length > 0)
                    chapter.Add(str);
            } while (str?.Length > 0);
        }
    }
}