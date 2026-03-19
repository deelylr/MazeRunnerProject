using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeRunnerProject
{
    internal class CEnemyClasses
    {
        // The Base Class (The Blueprint)
        public abstract class Enemy
        {
            public string Name { get; set; }
            public int PositionX { get; set; }
            public int PositionY { get; set; }

            // This is Polymorphism: Every enemy MUST move, 
            // but they will each do it differently.
            public abstract void Move();
        }

        // Example 1: A Ghost Enemy (Moves through walls)
        public class Ghost : Enemy
        {
            public override void Move()
            {
                // Logic for moving through walls
                Console.WriteLine("The Ghost floats through a wall!");
            }
        }

        // Example 2: A Trap (Doesn't move, just waits)
        public class SpikeTrap : Enemy
        {
            public override void Move()
            {
                // Logic for staying still
                Console.WriteLine("The Spike Trap stays hidden in the floor.");
            }
        }
    }
}
