using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Timer timer;
	public GameObject enemy;

	public float spawnChance;
	public int spawnAmt;

	GameObject go;
	EnemyScript es;

	Transform _transform;

	bool spawning = true;

	// Use this for initialization
	void Start () {
		_transform = transform;
		spawnChance = 1f;
		spawnAmt = 1;

		StartCoroutine("SpawnEnemy");
	}
	
	// Update is called once per frame
	void Update() {
		if (timer.running && !spawning) {
			spawning = true;
		}
		else if (!timer.running && spawning) {
			spawning = false;
//			spawning = true;
		}

		spawnAmt    = (int)(timer.curTime)/5 + 1;
		spawnChance = ((int)(timer.curTime)/1) * 0.01f + 0.30f;
	}
//	void Update () {
//		if (timer.running) {
////			SpawnEnemy();
//		}
//	}

	IEnumerator SpawnEnemy() {
		while (spawning) {
			if (UnityEngine.Random.value <= spawnChance){
				for (int i = 0; i < UnityEngine.Random.Range(1,spawnAmt); ++i) {
					go = Instantiate (enemy, _transform.position, _transform.rotation) as GameObject;
					es = go.GetComponent<EnemyScript>();
					es.timer = timer;	
				}
			}
			yield return new WaitForSeconds(UnityEngine.Random.Range(0.05f, .7f));
		}
	}
}
