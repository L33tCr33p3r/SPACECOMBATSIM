namespace SpaceCombatSim.Module
{
	internal interface IModule
	{
		public int Integrity { get; set; }
		public int MaxIntegrity { get; set; }
		public int ArmorClass { get; set; }

		public List<IModule> Connections { get; set; }

		/// <summary>
		/// Connect to another module.
		/// </summary>
		/// <param name="target"></param>
		/// <exception cref="ArgumentException"></exception>
		public void Connect(IModule target)
		{
			if (target == this)
				throw new ArgumentException("Tried to connect a Module to itself!");
			else if (Connections.Contains(target) && target.Connections.Contains(this))
				throw new ArgumentException("Tried to connect to an already connected Module!");
			else if (Connections.Contains(target) || target.Connections.Contains(this))
				throw new ArgumentException("Tried to connect with a module that has a connection in a partial state, where the connection does not exist both ways.");

			Connections.Add(target);
			target.Connections.Add(this);
		}
	}
}
