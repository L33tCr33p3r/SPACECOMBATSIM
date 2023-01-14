namespace SpaceCombatSim.Module
{
	internal interface IModule
	{
		public int Integrity { get; set; }
		public int MaxIntegrity { get; set; }
		public int ArmorClass { get; set; }

		public List<IModule> Connections { get; set; }
	}
}
