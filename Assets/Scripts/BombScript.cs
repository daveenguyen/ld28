using UnityEngine;
using System.Collections;

public class BombScript : MonoBehaviour {

	public float spreadSpeed = 1f;
	Transform _transform;

	// Use this for initialization
	void Start () {
		_transform = transform;
	}
	
	// Update is called once per frame
	void Update () {
//		_transform.localScale *= spreadSpeed*Time.deltaTime;
//		_transform.localScale.x += Time.deltaTime;
//		_transform.localScale.y += Time.deltaTime;
//		_transform.localScale.z += Time.deltaTime;
		_transform.localScale += Vector3.one * spreadSpeed * Time.deltaTime;

		if (_transform.localScale.x >= 90f) {
			Destroy(gameObject);
		}
//		_transform.localScale = _transform.localScale * 1.01f * Time.deltaTime;
	}
}
