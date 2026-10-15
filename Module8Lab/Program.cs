using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Windows.Markup;

class Pokemon
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int Level { get; set; }
}
// Describes the Pokemon class. 

class PokemonLINQLab
{
    static void Main()
    {
        // List of pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { ID = 1, Name = "Bulbasaur", Type = "Grass", Level = 15 },
            new Pokemon { ID = 2, Name = "Charmander", Type = "Fire", Level = 36 },
            new Pokemon { ID = 3, Name = "Squirtle", Type = "Water", Level = 10 },
            new Pokemon { ID = 4, Name = "Pikachu", Type = "Electric", Level = 22 },
            new Pokemon { ID = 5, Name = "Eevee", Type = "Normal", Level = 25},
            new Pokemon { ID = 6, Name = "Starmie", Type = "Water", Level = 13 } 
        };

        // LINQ Query
        // Queries the list for pokemon ready to evolve (>= 16)
        var readyToEvolve = from p in pokemons
                            where p.Level >= 16
                            orderby p.Level
                            select p;

        // Evecutes the query and displays the results
        Console.WriteLine("Pokemon Ready to Evolve: ");
        foreach (var p in readyToEvolve)
        {
            // Print the name, type, and level.
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");

        }  
        Console.WriteLine("\n_________________________");

        // LINQ query that queries the list of pokemon for Water Type pokemon
        var waterTypePokemon = from p in pokemons
                               where p.Type == "Water"
                               orderby p.Level
                               select p;
        

        // Executes the query and displays the data
        Console.WriteLine("\nWater Type Pokemon: ");
        foreach (var p in waterTypePokemon)
        {
            // Print the name and level.
            Console.WriteLine($"Name: {p.Name}, Level: {p.Level}");

        } 
    }       
}
