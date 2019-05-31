using System;

namespace Libraries
{
    class Program
    {
        static void Main(string[] args)
        {
            var BlackrockLibary = new Library();
            var books = BlackrockLibary.GetAllBooks();
        }
    }
}
