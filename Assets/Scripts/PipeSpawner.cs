using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	[SerializeField] private float maxTime = 1;
	private float timer = 0;
	public GameObject pipe;
	[SerializeField] private float height;
	
	// Use this for initialization
	void Start () {
		GameObject newPipe = Instantiate(pipe);
		newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(timer > maxTime) {
			GameObject newPipe = Instantiate(pipe);
			newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
			Destroy(newPipe, 5f);

			timer = 0;
		}

		timer += Time.deltaTime;
	}
}
