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
            //TASK1
            //SortedList<int, string> sorted = new SortedList<int, string>();

            //sorted.Add(1940, "Assembly");
            //sorted.Add(1964, "BASIC");
            //sorted.Add(1972, "C");
            //sorted.Add( 1970, "Pascal");
            //sorted.Add( 1983, "C++");
            //sorted.Add( 1991, "Python");
            //sorted.Add(1995, "Java");
            //sorted.Add( 2000, "C#");
            //sorted.Add(2014, "Swift");

            //foreach(var item in sorted)
            //{
            //    Console.WriteLine( $"Dilin adi:  {item.Value}       Dilin yaradildigi il:  {item.Key}");
            //}



            //task3

            List<Library> libraries = new List<Library>();
            List<Category> categories = new List<Category>();
            List<Book> books = new List<Book>();
        restartSwitch:
            Console.WriteLine("**************");
            Console.WriteLine("Ana Menu");
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
                        CreateCategory(categories);
                        break;

                    case "3":
                        Console.Clear();
                        CreateBook(books, categories);

                        break;

                    case "4":

                        break;

                    case "0":

                        Console.WriteLine("Kitabxana sizi yeniden gozleyir!");
                        return;

                    default:
                        Console.WriteLine( "Seciminiz duzgun deyil. Duzgun reqem daxil edin .");

                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            goto restartSwitch;





        }

        public static void CreateLibrary(List<Library> libraries)
        {
            Console.WriteLine("Yeni kitabxana yaradin:");
            Console.WriteLine(  "****************************************");

            while (true)
            {
                Console.Write("Kitabxananin adini daxil edin:");
                string name = Console.ReadLine().Trim();
                name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

                foreach (var item in libraries)
                {
                    if (item.Name == name)
                    {
                        throw new LibraryAlreadyExists();
                    }
                }
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

        public static void CreateCategory(List<Category> categories)
        {
            Console.WriteLine("Yeni category yaradin");
            Console.WriteLine( "**********************************");
            while (true)
            {
                Console.Write("Category nin adini daxil edin:");
                string name = Console.ReadLine().Trim();
                name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

                foreach(var item in categories)
                {
                    if(item.Name==name)
                    {
                        throw new CategoryAlreadyExists();
                    }
                }
                if (name.Length >= 3 && name.Length < 25)
                {
                    Category category = new Category(name);
                    categories.Add(category);
                    Console.WriteLine($"'{name}'adli category yaradildi.");
                }
                else
                {
                    throw new WrongInputException("Duzgun deyer daxil edin");
                }
                break;
            }
        }
        public static void CreateBook(List<Book> books, List<Category> categories)
        {
            
            Console.WriteLine("Yeni kitab yaradin:");
            Console.WriteLine("****************************");


            while (true)
            {
                Console.Write("Kitabin adini daxil edin:");
                string name = Console.ReadLine().Trim();
                name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

                Console.Write("Kitabin authorunu  daxil edin:");
                string author = Console.ReadLine().Trim();
                author = char.ToUpper(author[0]) + author.Substring(1).ToLower();

                foreach (var item in books)
                {
                    if (item.Name == name || item.Author == author)
                    {
                        throw new BookAlreadyExistsException();
                    }
                }

                if (name.Length > 3 && name.Length < 25 && author.Length > 3 && author.Length < 25)
                {
                    var category = ChooseCategory(categories);
                    Book book = new(name, author, category);
                    books.Add(book);
                    Console.WriteLine($"'{name}'adli kitab yaradildi.");
                    
                }
                else
                {
                    throw new WrongInputException();
                }
                break;
            }
        }

        public static Category ChooseCategory(List<Category> categories)
        {
            Console.WriteLine("Kateqoriya secin:");

            foreach (var item in categories)
            {
                Console.WriteLine(item);
            }

            bool input = int.TryParse(Console.ReadLine(), out int id);
            if (!input)
            {
                throw new WrongInputException();
            }
            foreach (Category category in categories)
            {
                if (category.Id == id)
                {
                    return category;
                }
            }
            throw new CategoryNotFoundException();
        }


    }
}
