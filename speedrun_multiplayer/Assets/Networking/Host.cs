using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Speedrun.Networking;
/// <summary>
/// Host.
/// </summary>
public class Host : MonoBehaviour {
	/// <summary>
	/// The ip.
	/// </summary>
	public string ip; 

	/// <summary>
	/// The is server connected.
	/// </summary>
	private bool isServerConnected;

	/// <summary>
	/// The is host disconnecting.
	/// </summary>
	private bool isHostDisconnecting;

	/// <summary>
	/// Initializes a new instance of the <see cref="Host"/> class.
	/// </summary>
	public Host() {
			// add host specific logic here.
	} 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
