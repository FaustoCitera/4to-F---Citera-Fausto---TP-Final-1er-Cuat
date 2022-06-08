using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
	public Text txt_min;
	public Text txt_segs;
	public float elapsedTime;
	public bool isCounting;

	// Start is called before the first frame update
	void Start()
	{
		elapsedTime = 0;
		isCounting = true;
	}

	// Update is called once per frame
	void Update()
	{
		float currentTime = Time.time;
		int minutos = Mathf.FloorToInt(((currentTime) / 60));
		txt_min.text = minutos.ToString();
		txt_segs.text = Mathf.Floor(currentTime % 60).ToString();
		if (isCounting)
		{
			elapsedTime += Time.deltaTime;
		}
		if(elapsedTime > 45)
		{
			SceneManager.LoadScene("Player1Wins");
		}
		
	}
}
