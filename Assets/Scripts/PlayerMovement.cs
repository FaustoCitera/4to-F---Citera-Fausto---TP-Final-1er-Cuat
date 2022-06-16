using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
	AudioSource source;
	public AudioClip Salto;
	public float movementSpeed;
	public float jumpForce;
	public int maxJumps;
	int hasJump;
	Rigidbody rb;

	// Start is called before the first frame update
	void Start()
    {
		hasJump = maxJumps;
		rb = GetComponent<Rigidbody>();
		source = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.D))
		{
			transform.position += new Vector3(movementSpeed, 0, 0);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.position -= new Vector3(movementSpeed, 0, 0);
		}
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += new Vector3(0, 0, movementSpeed);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position -= new Vector3(0, 0, movementSpeed);
		}
		if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
		{
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
			hasJump--;
			source.clip = Salto;
			source.Play();
		}
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "ground")
		{
			hasJump = maxJumps;
		}
	}
}
