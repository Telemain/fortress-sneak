using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flashlight : MonoBehaviour
{
	GameObject Player;
    Collider Spot_c, Player_c;
	Light lt;
	//bool caught = false;
	Quaternion origin;
	Quaternion target;
	int j = 0;
	bool searching = true;
	float facing;
	GameObject alarmBox;
	public GameObject gameOver;

    void Start()
    {
		Player = GameObject.Find("Player");
		alarmBox = GameObject.Find("AlarmBox");
		Spot_c = gameObject.GetComponent<Collider>();
		Player_c = Player.GetComponent<Collider>();
		lt = GetComponent<Light>();
		
		//origin = Quaternion.Euler(108, transform.eulerAngles.y, 0);
		//target = Quaternion.Euler(108, transform.eulerAngles.y + 180, 0);
		facing = transform.eulerAngles.y;
		
		origin = Quaternion.Euler(Random.Range(90, 130), facing, 0);
		target = Quaternion.Euler(Random.Range(155, 165), Random.Range(facing+90, facing+270), 0);
		
	}
	void FixedUpdate()
    {
		
		//if (Spot_c.bounds.Intersects(Player_c.bounds)){
			//lt.color = Color.Lerp(Color.white, Color.red, i++ * 0.01f);
			//caught = true;
			//Player.GetComponent<PlayerMovement>().enabled = false;
			
		//}else if ( !Spot_c.bounds.Intersects(Player_c.bounds) &&  false == caught )
		//{
		if( true == searching ){
			
			transform.rotation = Quaternion.Slerp(origin, target, j*0.02f);
			j++;
			
			if( 100 == j ){
				//Debug.Log(j);
				origin = target;
				target = Quaternion.Euler(Random.Range(155, 165), Random.Range(facing+90, facing+270), 0);
				j = 0;
				
			}
		}
		//}
	}
	void OnTriggerEnter (Collider Player_c){
		alarmBox.GetComponent<AudioSource>().Play();
		//lt.color = Color.Lerp(lt.color, Color.red, 0.01f);
		lt.color = Color.red;
		//caught = true;
		Player.GetComponent<PlayerMovement>().enabled = false;
		searching = false;
		
		gameOver.SetActive(true);
		
	}
	
		
	
}