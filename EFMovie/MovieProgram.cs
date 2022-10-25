using EFMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EFMovie
{
    public class MovieProgram
    {
        public List<string> SearchByGenre()
        {
            MovieContext mc = new MovieContext();
            List<Movie> movies = mc.Movies.ToList();
            Console.WriteLine("Here is a list of genres we have.");

            List<string> genres = new List<string>();
            foreach (Movie movie in movies)
            {
                if (genres.Contains(movie.Genre) == false)
                {
                    genres.Add(movie.Genre);
                }
            }

            int m = 1;
            foreach (string mov in genres)
            {
                Console.WriteLine(mov);
                m++;
            }
            Console.WriteLine("Please select a category to see the movies we have.");
            string chooseGenre = Console.ReadLine();
            List<string> titles = new List<string>();
            foreach (Movie movie in movies)
            {
                if (movie.Genre.Contains(chooseGenre))
                {
                    Console.WriteLine(movie.Title);
                    titles.Add(movie.Title);
                }
            }
            return titles;
            


        }
        public void SearchByTitle()
        {
            Console.WriteLine("Here is a list of movies we have:");
            MovieContext mc = new MovieContext();
            List<Movie> movies = mc.Movies.ToList();
            for (int i = 1; i < movies.Count; i++)
            {
                Console.WriteLine(i + " " + movies[i].Title);
            }
            Console.WriteLine("Please select by index the movie you wish to learn about.");
            int chooseTitle = int.Parse(Console.ReadLine());

            for (int i = 1; i < movies.Count; i++)
            {

                Console.WriteLine(chooseTitle + ": Title: " + movies[chooseTitle].Title + " Genre: " + movies[chooseTitle].Genre + " Runtime: " + movies[chooseTitle].Runtime);
                break;

            }
        }
    }
}
