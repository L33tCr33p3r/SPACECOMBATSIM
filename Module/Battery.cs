namespace SpaceCombatSim.Module
{
	internal class Battery : ModuleProperty
	{
		public int MaxPower { get; set; }
		public int StoredPower { get; set; }
		public int MaxCharge { get; set; }
		public int MaxDischarge { get; set;}
	}
}
