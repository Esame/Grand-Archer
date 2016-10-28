using UnityEngine;
using System.Collections;
public float spd = 100;
public class moving : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
			
	}
	void FixedUpdate () {
		float dir = Input.GetAxis("Horizontal");
		GetComponent<Rigidbody2D>().AddForce(dir * float * Vector2.right);
	}
}
