using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Speedrun.Networking;
/// <summary>
/// Game session.
/// </summary>
public class GameSession : MonoBehaviour {
	/// <summary>
	/// The session identifier.
	/// </summary>
	public string SessionId;

	/// <summary>
	/// Clientses the in game session.
	/// </summary>
	/// <returns>The in game session.</returns>
	public List<Client> clientsInGameSession; 

	/// <summary>
	/// The number of players in session.
	/// </summary>
	private int numOfPlayersInSession;

	/// <summary>
	/// The is server connected.
	/// </summary>
	private bool isServerConnected;

	/// <summary>
	/// The is host connected.
	/// </summary>
	private bool isHostConnected;

	/// <summary>
	/// The is game session in progress.
	/// </summary>
	private bool isGameSessionInProgress;

	/// <summary>
	/// Initializes a new instance of the <see cref="GameSession"/> class.
	/// </summary>
	public GameSession() { 
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
