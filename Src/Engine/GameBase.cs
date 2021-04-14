using System;
using System.Collections.Generic;

namespace FluxEngine {
	public class GameBase {
		//Constants
		public readonly float framesPerSecond = 30f;

		//Game Window
		protected string title = "FluxEngine";
		protected Vector2 screenSize = new Vector2(120, 30);
		protected ConsoleColor clearColor = ConsoleColor.White;

		public void SetTitle(string _title) {
			title = _title;
			Console.Title = title;
		}

		public void SetScreenSize(int width, int height) {
			if (width <= 0) width = 1;
			if (height <= 0) height = 1;
			screenSize = new Vector2(width, height);
		}

		public void SetClearColor(ConsoleColor _clearColor) {
			clearColor = _clearColor;
		}

		//Game Data
		public List<Entity> entityList = new List<Entity>();
		
		

		//Initializes the game and set's up the window
		public virtual void Init() {
			Console.SetWindowSize(screenSize.x, screenSize.y);
			Console.CursorVisible = false;

			Core.GFX.ClearScreen(screenSize, clearColor);
		}

		public virtual void Update() {
			Core.GFX.ClearScreen(screenSize, clearColor);
		}

		public virtual void UseInput(ConsoleKeyInfo Key) { }
	}
}
