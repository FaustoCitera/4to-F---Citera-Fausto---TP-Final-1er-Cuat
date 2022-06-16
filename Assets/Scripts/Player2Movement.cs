using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
	public float movementSpeed;
	public float jumpForce;
	public int maxJumps;
	AudioSource source;
	public AudioClip Salto;

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
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(movementSpeed, 0, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position -= new Vector3(movementSpeed, 0, 0);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(0, 0, movementSpeed);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position -= new Vector3(0, 0, movementSpeed);
		}
		if (Input.GetKeyDown(KeyCode.RightShift) && hasJump > 0)
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
