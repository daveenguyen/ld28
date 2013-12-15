using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public Timer timer;
	public float speed;

	public float zStart;
	public float pongSpeed;
	int pongHeight = 1;
	Transform _transform;

	int randMove = 0;


	// Use this for initialization
	void Start () {
		_transform = transform;
		speed     = UnityEngine.Random.Range(10f,30f);
		zStart    = UnityEngine.Random.Range(-8f,8f);
		pongSpeed = UnityEngine.Random.Range(5f,10f);
		randMove  = UnityEngine.Random.Range(0,4);
		pongHeight= UnityEngine.Random.Range(1,6);

		_transform.position = new Vector3(_transform.position.x, _transform.position.y, zStart);
	}
	
	// Update is called once per frame
	void Update () {
		MoveForward();
		MoveChange();
		DestroyOutRange();
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Debug.Log("STOP TIMER");
			timer.StopTimer();
		}
		else if (other.tag == "Bomb") {
			Destroy(gameObject);
		}
	}

	void MoveForward() {
		_transform.position += _transform.forward * speed * Time.deltaTime;
//		moveDir   = moveDir * speed * Time.deltaTime;
	}

	void MoveChange() {
//		_transform.position
		switch(randMove) {
		case 0:
			break;
		case 1:
			_transform.position = new Vector3(_transform.position.x, _transform.position.y, Mathf.PingPong(Time.time*pongSpeed, pongHeight) + zStart);
			break;
		case 2:
			speed += UnityEngine.Random.Range(0f,1f);
			break;
		default:
			break;
		}
	}

	void DestroyOutRange() {
		if (_transform.position.x < -19)
			Destroy(gameObject);
	}
}
