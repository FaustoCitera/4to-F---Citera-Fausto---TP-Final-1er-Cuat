using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player2")
		{ 
			GetComponent<MeshRenderer>().material.color = Color.red;
		}
		if (col.gameObject.tag == "Player1")
		{
			GetComponent<MeshRenderer>().material.color = Color.blue;
		}
	}
}
