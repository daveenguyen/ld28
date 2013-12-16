using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed = 15f;
	
	const int MAX_X = 15;
	const int MAX_Z = 8;

	public GameObject bomb;

	Transform _transform;
	Vector3 moveDir;
	// Use this for initialization
	void Start () {
		BombScript.bombCount = 1;
		_transform = transform;
		moveDir = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Fire1") != 0 && speed != 0) {
			DeployBomb();
		}
		moveDir.x = Input.GetAxis("Horizontal");
		moveDir.z = Input.GetAxis("Vertical");
		moveDir.Normalize();

		moveDir   = moveDir * speed * Time.deltaTime;

		moveDir.x = Mathf.Clamp(moveDir.x + transform.position.x, -MAX_X, MAX_X);
		moveDir.z = Mathf.Clamp(moveDir.z + transform.position.z, -MAX_Z, MAX_Z);
		_transform.position = moveDir;
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log(other.tag);
		if (other.tag == "Enemy") {
			speed = 0;
			HealthScript.getHurt = true;
			Destroy(gameObject);
		}
	}

	void DeployBomb() {
		if (BombScript.bombCount > 0) {
			Instantiate(bomb, _transform.position, Quaternion.identity);
			BombScript.bombCount--;
		}
	}
}
