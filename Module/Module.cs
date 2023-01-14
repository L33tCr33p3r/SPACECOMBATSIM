namespace SpaceCombatSim.Module
{
	public partial class Module : Node3D
	{
		public int Integrity { get; set; }
		public int ArmorClass { get; set; }
		public int DamageThreshold { get; set; }

		public List<Module> Connections { get; set; } = new();

		public PowerMode PowerMode { get; set; }
		public bool Volatile { get; set; }



		public override void _Ready()
		{
		}

		public override void _Process(double delta)
		{
		}
	}
}
