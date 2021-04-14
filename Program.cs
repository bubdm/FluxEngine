using System;
using FluxEngine;

namespace ProjectName {
	class Program {
		static void Main(string[] args) {
			//Initialize game and set window size & title
			Game1 game = new Game1();
			game.SetTitle("My First Console Game!");
			game.SetScreenSize(120, 30);
			//game.SetClearColor(ConsoleColor.Cyan);

			//Run the game's "Start" method
			game.Init();

			bool isRunning = true;
			while(isRunning) {
				//Update the game every tick
				isRunning = Core.Run(game);
			}
		}
	}
}
