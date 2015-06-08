using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public float speed;
		
	private Rigidbody rb;
		
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
		
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
			
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnCollisionStay(Collision collision)
	{
		Collider other = collision.collider;
		if (other.gameObject.CompareTag ("Player"))
		{	
			Application.LoadLevel("Menu");
		}
	}
}
