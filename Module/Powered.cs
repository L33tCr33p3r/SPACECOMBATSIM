namespace SpaceCombatSim.Module
{
	internal class Powered : ModuleProperty
	{
		public int MinUsage { get; set; }
		public int MaxUsage { get; set; }
		public int CurrentUsage { get; set; }
	}
}
