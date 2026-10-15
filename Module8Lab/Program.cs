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
    public int Attack { get; set; }
    // The base attack stat for this pokemon.
}
// Describes the Pokemon class. 

class PokemonLINQLab
{
    static void Main()
    {
        // List of pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { ID = 1, Name = "Bulbasaur", Type = "Grass", Level = 15, Attack = 49 },
            new Pokemon { ID = 2, Name = "Charmander", Type = "Fire", Level = 36, Attack = 52 },
            new Pokemon { ID = 3, Name = "Squirtle", Type = "Water", Level = 10, Attack = 48 },
            new Pokemon { ID = 4, Name = "Pikachu", Type = "Electric", Level = 22, Attack = 55 },
            new Pokemon { ID = 5, Name = "Eevee", Type = "Normal", Level = 25, Attack = 55},
            new Pokemon { ID = 6, Name = "Starmie", Type = "Water", Level = 13, Attack = 75 }, 
            new Pokemon { ID = 7, Name = "Pidgeotto", Type = "Flying", Level = 17, Attack = 60 },
            new Pokemon { ID = 8, Name = "Meowth", Type = "Normal", Level = 16, Attack = 45 },
            new Pokemon { ID = 9, Name = "Kakuna", Type = "Bug", Level = 12, Attack = 25 },
            new Pokemon { ID = 10, Name = "Magikarp", Type = "Water", Level = 15, Attack = 10 }
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


        // Module 8 coding Challenge
        Console.WriteLine("\n_________________________________\nCoding Challenge");
        // Query 1: LINQ Query that queries a list of pokemon with an attack of 50 or higher.
        var strongPokemon = (from p in pokemons
                            where p.Attack >= 50
                            select p).ToList();
        
        // Query 2: This Query sorts the pokemon in strongPokemon by name (alphabetical order).
        var sortStrongByName = (from p in strongPokemon
                                orderby p.Name
                                select p).ToList();
        
        // Displays the data returned from the sortStrongByName query
        Console.WriteLine("\nStrong Pokemon Sorted: ");
        foreach (var p in sortStrongByName)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Attack: {p.Attack}");
            // Displays the name, type, and attack attributes. 
        }

        // Query 3: This query sorts the water type pokemon by level
        var sortedWaterType = (from p in waterTypePokemon
                               orderby p.Level
                               select p).ToList();
        
        // Displays the data returned from the sortedWaterType query
        Console.WriteLine("\nWater Type Pokemon Sorted by Level: ");
        foreach (var p in sortedWaterType)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
            // Displays the name, type, and level attributes

        } 

    }       
}
