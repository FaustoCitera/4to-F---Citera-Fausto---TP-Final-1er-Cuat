using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
	public Text txt_time;
	public Text txt_timeFloored;
	public Text txt_min;
	public Text txt_segs;

	public GameObject txtPerdiste;

	public float elapsedTime;
	public float timeToDoSomething;
	public float timeToWait;

	public bool isCounting;

	// Start is called before the first frame update
	void Start()
	{
		elapsedTime = 0;
		isCounting = false;
	}

	// Update is called once per frame
	void Update()
	{
		float currentTime = Time.time;

		txt_time.text = currentTime.ToString();

		txt_timeFloored.text = Mathf.Floor(currentTime).ToString();

		int minutos = Mathf.FloorToInt(((currentTime) / 60));
		txt_min.text = minutos.ToString();

		txt_segs.text = Mathf.Floor(currentTime % 60).ToString();

		if (isCounting)
		{
			elapsedTime += Time.deltaTime;
		}

		if (currentTime > 3)
		{
			txtPerdiste.SetActive(true);
		}

		if (currentTime > timeToDoSomething)
		{
			timeToDoSomething += timeToWait;
			txtPerdiste.GetComponent<Text>().text = "Cambiaré en " + timeToDoSomething.ToString();
		}
	}
}
