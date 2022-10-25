using EFMovie.Models;

namespace EFMovie
{
    public class Program
    {
        static void Main(string[] args)
        {
            MovieProgram movieProgram = new MovieProgram();
            Console.WriteLine("Welcome. Would you like to search by genre or title?");
            string choosing = Console.ReadLine().ToLower();
            if (choosing == "genre")
            {
                movieProgram.SearchByGenre();
            }
            else if (choosing == "title")
            {
                movieProgram.SearchByTitle();
            }
            
            

        }
    }
}