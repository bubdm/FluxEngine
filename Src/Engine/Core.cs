using System;
using System.Diagnostics;
using System.Threading;

namespace FluxEngine {
	public static class Core {
		public static bool Run(GameBase game) {
			double frameTime = 1000.0f / game.framesPerSecond; //Converts "frames per second" to "ms per frame"
			long frameCount = 0;
			ConsoleKeyInfo keyPressed;

			do {
				while (!Console.KeyAvailable) {
					Stopwatch frameTimeCounter = Stopwatch.StartNew();

					//Game Loop
					game.Update();

					//End Frame
					frameTimeCounter.Stop();
					frameCount++;

					if (frameTimeCounter.Elapsed.TotalMilliseconds <= frameTime) {
						Thread.Sleep((int)(frameTime - frameTimeCounter.Elapsed.TotalMilliseconds));
					} else {
						Thread.Yield();
					}
				}

				keyPressed = Console.ReadKey();
				game.UseInput(keyPressed);

			} while (keyPressed.Key != ConsoleKey.Escape);

			return false;
		}

		public static class GFX {
			public static void Reset() {
				Console.SetCursorPosition(0, 0);
				Console.ResetColor();
			}

			public static void ClearScreen(Vector2 _screenSize, ConsoleColor _color) {
				Console.SetCursorPosition(0, 0);

				for (int y = 0; y < _screenSize.y; y++) {
					Console.BackgroundColor = _color;
					Console.Write(new string(' ', _screenSize.x));
				}
			}

			public static void SetPixelColor(Vector2 pos, ConsoleColor color) {
				Console.SetCursorPosition(pos.x, pos.y);
				Console.BackgroundColor = color;
				Console.Write(" ");
			}

			public static void SetSubPixelColor(Vector2 pos, ConsoleColor topColor, ConsoleColor bottomColor) {
				Console.ForegroundColor = topColor;
				Console.BackgroundColor = bottomColor;
				Console.SetCursorPosition(pos.x, pos.y);
				Console.Write("▀");
		}

			public static void DrawSquare(Vector2 pos, int width, int height, ConsoleColor color, bool doCenter = false) {
				Console.BackgroundColor = color;

				for (int yDif = 0; yDif < height; yDif++) {
					int offset = (int)MathF.Floor(width / 2);
					Console.SetCursorPosition(pos.x - (doCenter ? offset : 0), pos.y + yDif);
					Console.WriteLine(new string(' ', width));
				}
			}

			public static void DrawText(Vector2 pos, string text, ConsoleColor color = ConsoleColor.Black, ConsoleColor newClearColor = ConsoleColor.White) {
				Console.ForegroundColor = color;
				Console.BackgroundColor = newClearColor;

				Console.SetCursorPosition(pos.x, pos.y);
				Console.WriteLine(text);
			}
		}

		public static void AddEntity(GameBase gameBase, Entity entity) {
			gameBase.entityList.Add(entity);
		}
	}
}
