namespace SpaceCombatSim.Module
{
	public interface IModule
	{
		public int Integrity { get; set; }
		public int MaxIntegrity { get; set; }
		public int ArmorClass { get; set; }
		public int DamageThreshold { get; set; }

		public List<IModule> Connections { get; set; }
	}
}
