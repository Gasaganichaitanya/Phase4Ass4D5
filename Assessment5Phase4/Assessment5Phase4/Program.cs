// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using Assessment5Phase4;

class Program
{
    static List<Movie> MovieList = new List<Movie>()
    {
        new Movie() { Title="RRR",Year=2022},
        new Movie() { Title="Hi Nanna",Year=2023},
        new Movie() { Title="Jersey",Year=2020},
        new Movie() { Title="Pushpa",Year=2022},
        new Movie() { Title="Salar",Year=2023}
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Get all Movies");
            Console.WriteLine("2. Get Movie by title");
            Console.WriteLine("3. Add Movie ");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int Option = int.Parse(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    GetAllMovies();
                    break;
                case 2:
                    Console.Write("Enter Title Of the Movie: ");
                    string Title = Console.ReadLine();
                    GetMovieByTitle(Title);
                    break;
                case 3:
                    AddMovie();
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void GetAllMovies()
    {
        if (MovieList.Count == 0)
        {
            Console.WriteLine("No movies available.");
        }
        else
        {
            Console.WriteLine("All Movies:");
            foreach (var movie in MovieList)
            {
                Console.WriteLine($"{movie.Title} - {movie.Year}");
            }
        }
        Console.WriteLine();
    }

    static void GetMovieByTitle(string title)
    {
        var movie = MovieList.Find(m => m.Title.ToLower() == title.ToLower());

        if (movie != null)
        {
            Console.WriteLine($"Movie found: {movie.Title} - {movie.Year}");
        }
        else
        {
            Console.WriteLine($"Movie with title '{title}' not found.");
        }
        Console.WriteLine();
    }

    static void AddMovie()
    {
        Console.Write("Enter movie title: ");
        string title = Console.ReadLine();

        Console.Write("Enter movie year: ");
        int year = int.Parse(Console.ReadLine());

        MovieList.Add(new Movie { Title = title, Year = year });

        Console.WriteLine("Movie added successfully.");
        Console.WriteLine();
    }
}

