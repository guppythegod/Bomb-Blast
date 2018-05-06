using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public float speed = 25f;
    private Rigidbody2D rb;
	public float mapwidth = 12f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate() {
		// sets the new position from Input to var x
		float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;
		Vector2 newPosition = rb.position + Vector2.up * y;
		newPosition.y  = Mathf.Clamp(newPosition.y, - mapwidth, mapwidth);
		// tells the rigidbody component to move based on 'x'
		rb.MovePosition(newPosition);
	}

	void OnCollisionEnter2D() {
		Debug.Log("Player Collided !");
		//FindObjectOfType<GameManager>().EndGame();
	}
}
