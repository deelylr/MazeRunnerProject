using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeRunnerProject
{
    internal class Interfaces
    {
        // 1. For items that can be picked up (e.g., Coin, Key)
public interface ICollectable
    {
        void Collect();
    }

    // 2. For things that can take the damage or be destroyed (e.g., Player, Destructible Wall)
    public interface IDamageable
    {
        int Health { get; set; }
        void TakeDamage(int amount);
    }

    // 3. For things the player can interact with (e.g., Door, NPC)
    public interface IInteractable
    {
        void Interact();
    }
}
}
