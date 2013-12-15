using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {

	public float speed;
	private Transform _transform;

	// Use this for initialization
	void Start () {
		_transform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		_transform.Rotate(_transform.up, speed*Time.deltaTime, Space.World);
	}
}
