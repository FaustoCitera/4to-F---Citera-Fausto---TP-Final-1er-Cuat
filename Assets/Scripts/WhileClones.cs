using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileClones : MonoBehaviour
{
	public GameObject prefab;
	public GameObject spawnPoint;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       while (Player1Wins = True)
		{
			GameObject clon;
			clon = Instantiate(prefab);
			clon.transform.position = spawnPoint.transform.position - spawnPoint.transform.forward; ;
		}
    }
}
