using UnityEngine;
using System.Collections;

public class BombColor : MonoBehaviour {

	public float changeSpeed = 1f;
	Material _mat;
	// Use this for initialization
	void Start () {
		_mat = renderer.material;
		_mat.color = Color.green;
	}
	
	// Update is called once per frame
	void Update () {
		if (BombScript.bombCount <= 0) {
			_mat.color = Color.Lerp(_mat.color, Color.red, changeSpeed * Time.deltaTime);
		}
		else
			_mat.color = Color.green;
	}

}
