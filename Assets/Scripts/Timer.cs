using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public GameObject gameOver;
	public float time = 300;
	GameObject Player;
	public GameObject alarmBox;
	public Slider tSlider;
	bool caught = false;
	public Text countdown;
	int minutes = 0;
	int seconds = 0;

    // Start is called before the first frame update
    void Start()
    {
		Player = GameObject.Find("Player");
		alarmBox = GameObject.Find("AlarmBox");
    }

    // Update is called once per frame
    void Update()
    {
		time -= Time.deltaTime;
		tSlider.value = time;
		minutes = (int) time / 60;
		seconds = (int) time - (minutes * 60);
		countdown.text = minutes.ToString() + ":" + seconds.ToString("00");
		if( 0 > time && false == caught ){
			caught = true;
			timerOver();
		}

    }
	void timerOver(){
		alarmBox.GetComponent<AudioSource>().Play();
		Player.GetComponent<PlayerMovement>().enabled = false;

		gameOver.SetActive(true);
	}
}
