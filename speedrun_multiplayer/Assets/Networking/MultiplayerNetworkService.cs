using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Multiplayer network service.
/// </summary>
namespace Speedrun.Networking { 
	/// <summary>
	/// Multiplayer network service.
	/// </summary>
	public class MultiplayerNetworkService : MonoBehaviour {
		///<summary> 
		/// DESCRIPTION: The MultiplayerNetworkService class will insert after the matchmaker passes us the players in the gamesession and the host of the game.
		/// </summary>
		public Host GameHost { get; set; }

		/// <summary>
		/// Gets or sets the host ip address.
		/// </summary>
		/// <value>The host ip address.</value>
		public string HostIpAddress { get; set; }

		/// <summary>
		/// Gets or sets the state of the client game.
		/// </summary>
		/// <value>The state of the client game.</value>
		private SharedData ClientGameState { get; set; }

		/// <summary>
		/// Gets or sets the connected players in game session.
		/// </summary>
		/// <value>The connected players in game session.</value>
		private List<Client> ConnectedPlayersInGameSession { get; set; }

		/// <summary>
		/// Network status.
		/// </summary>
		private enum NetworkStatus { 
			SERVER_RUNNING,
			SERVER_DOWN,
			SERVER_ERROR,
			GAME_IN_SESSON,
			GAME_STARTING,
			GAME_ENDING,
			HOST_NOT_CONNECTED,
			CLIENT_NOT_CONNECTED
		}

		/// <summary>
		/// DESCRIPTION: The default constructor for the MultiplayerNetworkService. Initializes the objects and hooks in required data and/or requests it from an external API
		/// </summary>
		public MultiplayerNetworkService() { 
			this.GameHost = null;
			this.HostIpAddress = null;
			this.ConnectedPlayersInGameSession = null;

			NetworkStatus state = NetworkStatus.SERVER_ERROR;
		    Debug.LogWarning ("[WARNING]: The Network was instantiated without the required parameters. Things might crash."); 	
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="Speedrun.Networking.MultiplayerNetworkService"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="hostIp">Host ip.</param>
		/// <param name="players">Players.</param>
		public MultiplayerNetworkService(Host host, string hostIp, List<Client> players) { 
			NetworkStatus ServerHealth = NetworkStatus.HOST_NOT_CONNECTED;

			this.GameHost = host;
			this.HostIpAddress = hostIp;
			this.ConnectedPlayersInGameSession = players;

			if (ServerHealth == NetworkStatus.HOST_NOT_CONNECTED) {
				Debug.Log ("Something is wrong with the server");
				throw new UnityException (); 
			}

			if (ServerHealth == NetworkStatus.SERVER_RUNNING) { 
				switch (ServerHealth) { 
				case ServerHealth.SERVER_RUNNING:
					StartGameSession ();
					break;
				case ServerHealth.SERVER_DOWN:
					Debug.Log ("The service was called correctly, but there is a problem with the server. Exiting.");
					ExitGameSession ();
					break;
				case ServerHealth.SERVER_ERROR:
					Debug.Log ("There is a server problem. There may be problems with the game.");
					break;
				}
			}
		}
		/// <summary>
		/// Starts the game session.
		/// </summary>
		/// <returns>The game session.</returns>
		public void StartGameSession() { 
				
		} 

		/// <summary>
		/// Exits the game session.
		/// </summary>
		public void ExitGameSession() { 
				
		}

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}
	}
} 