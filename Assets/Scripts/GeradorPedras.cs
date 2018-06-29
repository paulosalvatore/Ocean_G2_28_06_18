using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorPedras : MonoBehaviour {

	public GameObject pedrasPrefab;
	public float delay = 2f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("GerarPedras", delay, delay);
	}

	void GerarPedras () {
		Instantiate (pedrasPrefab);
	}
}
