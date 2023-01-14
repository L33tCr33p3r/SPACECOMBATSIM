namespace SpaceCombatSim.Module
{
	internal interface IPowered : IModule
	{
		public int MinUsage { get; set; }
		public int MaxUsage { get; set; }
		public int CurrentUsage { get; set; }
	}
}
