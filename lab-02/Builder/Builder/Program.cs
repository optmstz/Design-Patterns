using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;

namespace BuilderClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a hero
            var heroBuilder = new HeroBuilder();
            var heroDirector = new Director(heroBuilder);

            heroDirector.ConstructHero(
                height: 180,
                build: "Muscular",
                hairColor: "Brown",
                eyeColor: "Green",
                clothing: "Armor",
                inventory: new List<string> { "Sword", "Shield" },
                goodDeeds: new List<string> { "Saved a village", "Rescued a princess" }
            );

            var hero = heroBuilder.Build();
            Console.WriteLine("Hero created:");
            Console.WriteLine(hero);

            Console.WriteLine();

            // Creating an enemy
            var enemyBuilder = new EnemyBuilder();
            var enemyDirector = new Director(enemyBuilder);

            enemyDirector.ConstructEnemy(
                height: 170,
                build: "Slender",
                hairColor: "Black",
                eyeColor: "Red",
                clothing: "Dark Robe",
                inventory: new List<string> { "Dark Magic Tome", "Dagger" },
                evilDeeds: new List<string> { "Destroyed a kingdom", "Enslaved innocent creatures" }
            );

            var enemy = enemyBuilder.Build();
            Console.WriteLine("Enemy created:");
            Console.WriteLine(enemy);
        }
    }
}
