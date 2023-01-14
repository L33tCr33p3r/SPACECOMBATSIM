namespace SpaceCombatSim.Module
{
	public abstract record PowerMode;

	public record Unpowered : PowerMode;

	public record Powered : PowerMode;

	public record Generator(int Generation) : PowerMode;

	public record FixedDrain(int Drain) : Powered;

	public record DynamicDrain(int MinDrain, int MaxDrain) : Powered;
}
