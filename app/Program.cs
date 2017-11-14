using System;
using Film;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var film = new Film();
            film.title ="Thor";
            Console.WriteLine(film.title);
        }
    }
}
