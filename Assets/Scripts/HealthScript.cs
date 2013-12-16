using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public float changeSpeed = 1f;
	public static bool getHurt = false;
	Material _mat;
	// Use this for initialization
	void Start () {
		getHurt = false;
		_mat = renderer.material;
		_mat.color = Color.green;
	}
	
	// Update is called once per frame
	void Update () {
		if (getHurt) {
			_mat.color = Color.Lerp(_mat.color, Color.red, changeSpeed * Time.deltaTime);
		}
		else
			_mat.color = Color.green;
	}
}
