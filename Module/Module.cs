namespace SpaceCombatSim.Module
{
	public class Module
	{
		public int Integrity { get; set; }
		public int MaxIntegrity { get; set; }
		public int ArmorClass { get; set; }

		public bool IsIntact { get; set; }

		public List<Module> Connections { get; set; }

		/// <summary>
		/// Connect to another module.
		/// </summary>
		/// <param name="target"></param>
		/// <exception cref="ArgumentException"></exception>
		public void Connect(Module target)
		{
			if (target == this)
				throw new ArgumentException("Tried to connect a Module to itself!");
			else if (Connections.Contains(target) && target.Connections.Contains(this))
				throw new ArgumentException("Tried to connect to an already connected Module!");

			Connections.Add(target);
			target.Connections.Add(this);
		}

		/// <summary>
		/// Disconnect from another module.
		/// </summary>
		/// <param name="target"></param>
		/// <exception cref="ArgumentException"></exception>
		public void Disconnect(Module target)
		{
			if (target == this)
				throw new ArgumentException("Tried to disconnect a Module from itself!");
			else if (!Connections.Contains(target) && !target.Connections.Contains(this))
				throw new ArgumentException("Tried to disconnect from an already disconnected Module!");

			Connections.Remove(target);
			target.Connections.Remove(this);
		}

		/// <summary>
		/// Returns the list of all modules that are both intact and have a path of intact modules to the current instance. 
		/// </summary>
		/// <returns></returns>
		public List<Module> FindAccessableModules()
		{
			var accessables = new List<Module> { this };
			var index = 0;

			while (index < accessables.Count)
			{
				foreach (Module module in accessables[index].Connections)
					if (module.IsIntact && !accessables.Contains(module))
						accessables.Add(module);
				index++;
			}

			return accessables;
		}
	}
}
