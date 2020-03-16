using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingBird : MonoBehaviour {

	[SerializeField] private GameManager gameManager;
	[SerializeField] private float velocity = 1;
	private Rigidbody2D rb;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			// jump
			rb.velocity = Vector2.up * velocity;
		} 
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		gameObject.transform.position = Vector3.down * velocity;
		gameManager.GameOver();
	}
}
