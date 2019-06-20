using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {

            Duck duck = new Duck("Frank", 10);
            Duck duck2 = new Duck("Bob", 20);
            Duck duck3 = new Duck("Anser", 40);
            Duck duck4 = new Duck("Eugenie", 60);
            Duck duck5 = new Duck("Alex", 80);

            Player player1 = new Player("Tom", 0);
            Player player2 = new Player("Warren", 0);

            List<Duck> ducks = new List<Duck>();
            ducks.Add(duck);
            ducks.Add(duck2);
            ducks.Add(duck3);
            ducks.Add(duck4);
            ducks.Add(duck5);

            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);

            var shuffleducks = ducks.OrderBy(a => Guid.NewGuid()).ToList();

            Console.WriteLine(shuffleducks[0].name);
            Console.WriteLine(shuffleducks[0].coolness);
            Console.WriteLine(shuffleducks[1].name);
            Console.WriteLine(shuffleducks[1].coolness);

            

            if (shuffleducks[0].coolness > shuffleducks[1].coolness)
            {
                Console.WriteLine(shuffleducks[0].name);
                player1.score =+ 10;
                Console.WriteLine($"Duck: {shuffleducks[0].name}, {player1.name}, {player1.score}");

            }
            else
            {
                Console.WriteLine(shuffleducks[1].name);
                player2.score = +10;
                Console.WriteLine($"Duck: {shuffleducks[1].name}, {player2.name}, {player2.score}");

            }

        }
    }
}
