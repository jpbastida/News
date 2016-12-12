using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProgramNews
{
    class Program
    {
        static string[] commentsSaved1 = new string[5];
        static string[] commentsSaved2 = new string[5];
        static string[] commentsSaved3 = new string[5];
        static int a = 0, b = 0, c = 0;
        
        static void Main(string[] args)
        {
            Console.WindowHeight = 42;
            Console.WindowWidth = 170;
            while (true)
            {
                Strings str = new Strings();
                showNews();
                Console.WriteLine();
                Console.Write("Choose the news to read: ");
                int optionNews = int.Parse(Console.ReadLine());
                Console.WriteLine();
                choosedNews(optionNews);
            }
        }

        static void showNews()
        {
            Strings str = new Strings();
            string headerNews = "";

            for (int i = 0; i < 50; i++)
            {
                headerNews += str.FirstNews[i];
            }
            Console.WriteLine("1. " + headerNews);
            headerNews = "";

            for (int i = 0; i < 50; i++)
            {
                headerNews += str.SecondNews[i];
            }
            Console.WriteLine("2. " + headerNews);
            headerNews = "";

            for (int i = 0; i < 50; i++)
            {
                headerNews += str.ThirdNews[i];
            }
            Console.WriteLine("3. " + headerNews);
            headerNews = "";
        }

        static void choosedNews(int option)
        {
            Strings str = new Strings();

            switch (option)
            {
                case 1:
                    Console.WriteLine("1. Russia praises possible Trump pick Rex ");
                    Console.WriteLine();
                    Console.WriteLine(str.FirstNews);
                    comments(1);
                    break;

                case 2:
                    Console.WriteLine("2. Colombia plane crash: passengers were not told to wear seatbelts, survivor says");
                    Console.WriteLine();
                    Console.WriteLine(str.SecondNews);
                    comments(2);
                    break;

                case 3:
                    Console.WriteLine("3. Cairo bombing: Sisi names suicide bomber as Coptic Christians protest");
                    Console.WriteLine();
                    Console.WriteLine(str.ThirdNews);
                    comments(3);
                    break;

                default:
                    Console.WriteLine("Option unavailable, choose another.");
                    break;
            }
        }

        private static void comments(int fromNews)
        {
            switch (fromNews)
            {
                case 1:
                    Console.WriteLine(@"1. Add comment.
2. See comments.
");
                    Console.Write("Choose an option: ");
                    int option1Com = int.Parse(Console.ReadLine());
                    switch (option1Com)
                    {
                        case 1:
                            addComent(a);
                            a++;
                            break;
                        case 2:
                            seeComents(1);
                            break;
                    }

                    break;

                case 2:
                    Console.WriteLine(@"1. Add comment.
2. See comments.
");
                    Console.Write("Choose an option: ");
                    int option2Com = int.Parse(Console.ReadLine());
                    switch (option2Com)
                    {
                        case 1:
                            addComent2(b);
                            b++;
                            break;
                        case 2:
                            seeComents(2);
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine(@"1. Add comment.
2. See comments.
");
                    Console.Write("Choose an option: ");
                    int option3Com = int.Parse(Console.ReadLine());
                    switch (option3Com)
                    {
                        case 1:
                            addComent3(c);
                            c++;
                            break;
                        case 2:
                            seeComents(3);
                            break;
                    }
                    break;
            }
        }

        private static void seeComents(int news)
        {
            int x = 1;
            if (news == 1)
            {
                foreach (var comment in commentsSaved1)
                {
                    Console.Write(x);
                    Console.WriteLine(comment);
                    Console.WriteLine();
                    x++;
                }
            }

            if (news == 2)
            {
                foreach (var comment in commentsSaved2)
                {
                    Console.Write(x);
                    Console.WriteLine(comment);
                    Console.WriteLine();
                    x++;
                }
            }
            if (news == 3)
            {
                foreach (var comment in commentsSaved3)
                {
                    Console.Write(x);
                    Console.WriteLine(comment);
                    Console.WriteLine();
                    x++;
                }
            }

        }

        private static void addComent(int index)
        {
            
            string comm = Console.ReadLine();
            Console.WriteLine("Comment: " + comm);
            commentsSaved1[index] = comm;
            Console.WriteLine();
        }

        private static void addComent2(int index)
        {

            string comm = Console.ReadLine();
            Console.WriteLine("Comment: " + comm);
            commentsSaved2[index] = comm;
            Console.WriteLine();
        }

        private static void addComent3(int index)
        {

            string comm = Console.ReadLine();
            Console.WriteLine("Comment: " + comm);
            commentsSaved3[index] = comm;
            Console.WriteLine();
        }
    }
}
