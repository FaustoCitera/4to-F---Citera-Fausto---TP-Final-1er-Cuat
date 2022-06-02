using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float movementSpeed;
	public float rotationSpeed;
	public float jumpHeight;

	// Start is called before the first frame update
	void Start()
    {
        
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
		if (Input.GetKeyDown(KeyCode.Space))
		{
			transform.position = new Vector3(0, jumpHeight, 0);
		}
      }
   }
