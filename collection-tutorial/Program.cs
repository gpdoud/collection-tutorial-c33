using System;
using System.Collections.Generic;

namespace collection_tutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			var rnd = new Random();
			int[] game = new int[10];
			//var frames = new List<int>();
			for (var idx = 0; idx < 10; idx++)
			{ 
				var frame = rnd.Next(0, 31);
				game[idx] = frame;
				//	frames.Add(frame);
			}
			var sum = 0;
			foreach(var score in game)
			{
				sum += score;
			}
			Console.WriteLine($"Games is {game}");





















			//var listOfNumbers = new List<int>();
			//listOfNumbers.Add(98);
			//listOfNumbers.Add(7);
			//listOfNumbers.Add(56);
			//listOfNumbers.Add(13);
			//listOfNumbers.Add(72);
			//listOfNumbers.Add(42);
			//listOfNumbers.Add(44);

			//var sum = 0;
			//foreach(var nbr in listOfNumbers)
			//{
			//	sum += nbr; // sum = sum + nbr
			//}
			//Console.WriteLine($"Sum is {sum}");
		}
	}
}
