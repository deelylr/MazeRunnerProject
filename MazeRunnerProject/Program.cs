using System;
using System.Collections.Generic;
using static MazeRunnerProject.CEnemyClasses;

class Program
{
    static void Main(string[] args)
    {
        // Demonstrating COLLECTIONS and POLYMORPHISM (Requirement 3 & 5)
        List<Enemy> mazeEnemies = new List<Enemy>();

        mazeEnemies.Add(new Ghost { Name = "Casper" });
        mazeEnemies.Add(new SpikeTrap { Name = "Floor Spikes" });

        Console.WriteLine("--- Maze Runner Logic Test ---");

        foreach (var enemy in mazeEnemies)
        {
            Console.WriteLine($"Encountered: {enemy.Name}");
            enemy.Move(); // This calls the specific version for each enemy (Polymorphism)
        }
    }
}

