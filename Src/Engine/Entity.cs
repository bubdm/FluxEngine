using System;

namespace FluxEngine {
	public class Entity {
		public string name;
		public ConsoleColor color;
		public Vector2 pos;

		public Entity(string _name, ConsoleColor _color, Vector2 _pos) {
			name = _name;
			color = _color;
			pos = _pos;
		}
	}
}
