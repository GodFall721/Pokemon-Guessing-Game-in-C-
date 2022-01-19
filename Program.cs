

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] pokemongen1list = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran", "Nidorina", "Nidoqueen", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch’d", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr.Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew"};
            int randomPokemonNumber = rand.Next(1, 152) - 1;
            string randompokemon = pokemongen1list[randomPokemonNumber].ToLower();
            bool CorrectGuess = false;
            string pokemonguess = "";

            Console.WriteLine("Guess a Pokemon from Generation 1");

            while (!CorrectGuess)
            {
                int guessedPokemonNumber = 0;

                while (true)
                {
                    //attempt guess
                    pokemonguess = Console.ReadLine().ToLower();

                    //check for correct guess

                    bool valid = false;
                    
                    for (int i = pokemongen1list.Length-1; i >= 0; i--)
                    {
                        if (pokemonguess == pokemongen1list[i].ToLower())
                        {
                            
                            guessedPokemonNumber = i;
                            valid = true;
                            break;
                        }
                    }
                    if(valid)
                    {
                        break;
                    }                                 
                    Console.WriteLine("That doesn't appear to be a valid gen 1 pokemon");
                }

                if (randompokemon == pokemonguess)
                {
                    //if correct guess congradulate and close

                    Console.WriteLine("Congrats you managed to guess " + pokemonguess + " youre a true trainer in my eyes!" );
                    Console.WriteLine();
                }
                //if not try again
                else {
                    Console.WriteLine("You have guessed wrong, try again.");

                    Console.WriteLine("Try a pokemon with a ");
                    if (guessedPokemonNumber < randomPokemonNumber)
                    {
                        Console.Write("Higher");
                    }
                    else
                    {
                        Console.Write("Lower");
                    }
                    Console.WriteLine("Number in the Pokedex");
                }
            }

        }

    }
}

       




















































