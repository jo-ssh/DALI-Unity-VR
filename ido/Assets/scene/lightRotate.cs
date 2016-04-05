using UnityEngine;
using System.Collections;

public class lightRotate : MonoBehaviour {


	public GameObject gameLight;
	public float step = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		gameLight.transform.Rotate(Vector3.up * Time.deltaTime / step, Space.World);

	}
}
