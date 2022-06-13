using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhileClones : MonoBehaviour
{
	public GameObject objectToClone;
	public int cloneAmount;
	public void CloneObject()
	{
		int contador = 0;
		while (contador < cloneAmount)
		{
			Instantiate(objectToClone);
			contador++;
		}
	}
}
