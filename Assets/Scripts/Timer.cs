using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public bool  running;
	public float curTime;

	public TextMesh _textmesh;
	float    _startTime;
	float    _endTime;

	void Start() {
		_startTime = 0;
		_endTime   = 0;
		running   = false;
		StartTimer();
	}
	
	void Update() {
//		if (Input.GetKey(KeyCode.A))
//			StartTimer();
//		else if (Input.GetKey(KeyCode.S))
//			StopTimer();

		if (running) {
			curTime = Time.time - _startTime;
			_textmesh.text = curTime.ToString();
		}

	}

	void StartTimer() {
		_startTime = Time.time;
		running   = true;
	}

	public void StopTimer() {
		if (running) {
			_endTime = Time.time;
			running = false;
			curTime = _endTime - _startTime;
			_textmesh.text = curTime.ToString();
		}
	}
}
