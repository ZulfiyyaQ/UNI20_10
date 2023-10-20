using System.Drawing;
using System.Linq.Expressions;
using task14.Exseptions;
using task14.Models;

namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Library> libraries = new List<Library>();
            List<Category> categories = new List<Category>();
            List<Book> books = new List<Book>();
        restartSwitch:
            Console.WriteLine("**************");
            Console.WriteLine("Ana Menu" );
            Console.WriteLine("**************");
            Console.WriteLine("[1] Yeni kitabxana yarat");
            Console.WriteLine("[2] Yeni kateqoriya yarat");
            Console.WriteLine("[3] Yeni kitab yarat");
            Console.WriteLine("[4] Kitabxanaya daxil ol");
            Console.WriteLine("[0] Programdan chix");

            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        CreateLibrary(libraries);
                        break;
                    case "2":
                        Console.Clear();
                        CreateCategory(libraries);
                        break;

                    case "4":

                        break;

                    case "0":

                        break;

                    default:

                        break;
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            goto restartSwitch;





        }

        public static void CreateLibrary(List<Library>libraries)
        {
            Console.WriteLine("Yeni kitabxana yarat:");
            while (true)
            {
                Console.Write("Kitabxananin adini daxil edin:");
                string name = Console.ReadLine().Trim();
                if (name.Length > 3 && name.Length < 25)
                {
                    Library library = new Library(name);
                    libraries.Add(library);
                    Console.WriteLine($"'{name}'adli kitabxana yaradildi.");
                }
                else
                {
                    throw new WrongInputException("Duzgun deyer daxil edin");
                }
                break;
            }
        }

        public static void CreateCategory(List<Library>libraries)
        {
            Console.WriteLine("Yeni category yaradin");
            while (true)
            {
                Console.Write("Category nin adini daxil edin:");
                string name = Console.ReadLine().Trim();
                if (name.Length > 3 && name.Length < 25)
                {
                    Library library = new Library(name);
                    libraries.Add(library);
                    Console.WriteLine($"'{name}'adli category yaradildi.");
                }
                else
                {
                    throw new WrongInputException("Duzgun deyer daxil edin");
                }
                break;
            }
        }

    }
}