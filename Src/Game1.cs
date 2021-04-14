using System;
using System.Collections.Generic;
using System.Text;
using FluxEngine;

namespace ProjectName {
    public class Game1 : GameBase {
		public override void Init() {
			base.Init();

			//var player = new Entity("Player", ConsoleColor.Black, new Vector2(0, 0));
			//Core.AddEntity(this, player);
		}

		public override void Update() {
			base.Update();

			foreach (Entity e in entityList) {
				Core.GFX.SetPixelColor(e.pos, e.color);

				if (e.pos.y >= 0 && e.pos.y <= screenSize.y - 1) {
					
				}

				if (e.pos.x >= 0 && e.pos.x <= screenSize.x - 1) {
					
				}
			}

			Core.GFX.DrawText(new Vector2(0, 0), "▀");
			Core.GFX.DrawText(new Vector2(1, 0), "▄");
			Core.GFX.DrawText(new Vector2(2, 0), "█");

			Core.GFX.DrawText(new Vector2(0, 2), "░");
			Core.GFX.DrawText(new Vector2(1, 2), "▒");
			Core.GFX.DrawText(new Vector2(2, 2), "▓");

			Core.GFX.SetPixelColor(new Vector2(5, 5), ConsoleColor.Black);
			Core.GFX.SetSubPixelColor(new Vector2(6, 5), ConsoleColor.Red, ConsoleColor.Blue);
			Core.GFX.SetSubPixelColor(new Vector2(7, 5), ConsoleColor.Green, ConsoleColor.Magenta);

			Core.GFX.Reset();
		}
	}
}
