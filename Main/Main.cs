namespace SpaceCombatSim.Main
{
	public partial class Main : Node
	{
		/// <summary>
		/// Starts a Multiplayer server
		/// </summary>
		/// <param name="port"></param>
		public void StartMultiplayerServer(int port)
		{
			var peer = new ENetMultiplayerPeer();

			peer.CreateServer(port);

			// Make the server do things when someone joins/leaves here

			Multiplayer.MultiplayerPeer = peer;
		}

		/// <summary>
		/// Connect to an already running multiplayer server
		/// </summary>
		/// <param name="ipAddress"></param>
		/// <param name="port"></param>
		public void StartMultiplayerClient(string ipAddress, int port)
		{
			var peer = new ENetMultiplayerPeer();

			peer.CreateClient(ipAddress, port);

			Multiplayer.MultiplayerPeer = peer;
		}

		public override void _Ready()
		{
		}

		public override void _Process(double delta)
		{
		}
	}
}
