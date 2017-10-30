using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject CubePreFab;
	GameObject currentCube;
	static GameObject selectedCube;
	Vector3 cubePosition;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 16; i++){
			cubePosition = new Vector3 (i*2-16, 0, 0);
			currentCube = (GameObject)Instantiate (CubePreFab, cubePosition, Quaternion.identity);
			currentCube.GetComponent <Renderer> ().material.color = Color.white;
		}
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public static void ProcessClick (GameObject clickedCube){
		if (selectedCube != null) {
			selectedCube.GetComponent <Renderer> ().material.color = Color.white;
		}
		clickedCube.GetComponent <Renderer> ().material.color = Color.red;
		selectedCube = clickedCube;
	}
}


	

