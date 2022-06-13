using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeManager : MonoBehaviour
{
	public TextMeshPro TMP_Min;
	public TextMeshPro TMP_seg;
	public Text txt_min;
	public Text txt_segs;
	public float elapsedTime;
	public bool isCounting;
	float currentTime = 0;
	// Start is called before the first frame update
	void Start()
	{
		elapsedTime = 0;
		isCounting = true;
	}

	// Update is called once per frame
	void Update()
	{
		currentTime += Time.deltaTime;
		int minutos = Mathf.FloorToInt(((currentTime) / 60));
		//txt_min.text = minutos.ToString();
		TMP_Min.text = minutos.ToString();
		//txt_segs.text = Mathf.Floor(currentTime % 60).ToString();
		TMP_seg.text = Mathf.Floor(currentTime % 60).ToString();
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
