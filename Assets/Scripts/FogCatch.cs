using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FogCatch : MonoBehaviour
{
	
	
	GameObject alarmBox;
	public GameObject gameOver;
	GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
		alarmBox = GameObject.Find("AlarmBox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter (Collider Player_c){
		alarmBox.GetComponent<AudioSource>().Play();
		
		gameOver.SetActive(true);
		
		
	}
	public void restart(){
		string scene = SceneManager.GetActiveScene().name.ToString();
		SceneManager.LoadScene( scene.ToString() );
	}
}
