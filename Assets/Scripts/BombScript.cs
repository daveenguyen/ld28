using UnityEngine;
using System.Collections;

public class BombScript : MonoBehaviour {
	public static int bombCount;
	public float spreadSpeed = 1f;
	Transform _transform;

	// Use this for initialization
	void Start () {
		_transform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		_transform.localScale += Vector3.one * spreadSpeed * Time.deltaTime;

		if (_transform.localScale.x >= 90f) {
			Destroy(gameObject);
		}
	}
}
