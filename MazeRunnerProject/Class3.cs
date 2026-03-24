using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeRunnerProject
{
	public class Player
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Score { get; set; }

		public void TakeDamage(int amount)
		{
			Health -= amount;
			Console.WriteLine($"Carefull!! Damage taken by {Name} now is {amount}!! Your health now {Health}");

		}
		public void AddScore(int points)
		{
			Score += points;
			Console.WriteLine($"{Name} gained {points} points! Total now is {Score}");
		}
	}
}
