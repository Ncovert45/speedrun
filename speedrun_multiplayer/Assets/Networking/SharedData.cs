using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Speedrun.Networking; 

/// <summary>
/// Shared data.
/// </summary>
public class SharedData : MonoBehaviour {
	/// <summary>
	/// The objects in game session.
	/// </summary>
	public List<GameObject> objectsInGameSession { get; set; }

	/// <summary>
	/// Gets or sets the injected data from server.
	/// </summary>
	/// <value>The injected data from server.</value>
	public string injectedDataFromServer  { get; set; }

	/// <summary>
	/// Gets or sets the player coordinate positions.
	/// </summary>
	/// <value>The player coordinate positions.</value>
	public List<Vector3> playerCoordinatePositions  { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="SharedData"/> class.
	/// </summary>
	public SharedData() { 
		throw new System.NotImplementedException (); 
	} 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
