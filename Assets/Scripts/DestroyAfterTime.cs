using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

	public float speed = 5f;
	public float destroyTime = 1f;

	Transform _transform;

	// Use this for initialization
	void Start () {
		_transform = transform;
		Destroy(gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update () {
		_transform.Translate(Vector3.left*Time.deltaTime*speed);
	}
}
