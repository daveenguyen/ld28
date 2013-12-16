using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public bool  running;
	public float curTime;

	public GameObject go;
	public TextMesh _textmesh;
	float    _startTime;
	float    _endTime;
	public static int score;

	void Start() {
		_startTime = 0;
		_endTime   = 0;
		running   = false;
		StartTimer();
	}
	
	void Update() {
		if (running) {
			curTime = Time.time - _startTime;
			score = (int)(curTime*100f);
			_textmesh.text = "Score: " + score.ToString();
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
			score = (int)(curTime*100f);
			_textmesh.text = "Score: " + score.ToString();

			if (go != null) go.SetActive(true);

			gameObject.SetActive(false);
		}
	}
}
