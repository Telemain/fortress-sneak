using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	bool paused = false;
	public GameObject pauseMenu;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
			paused = !paused;
			if( paused ){
				pause();
			}else{
				unpause();
			}
		}
    }
	void pause(){
		Time.timeScale = 0f;
		pauseMenu.SetActive(true);
	}
	void unpause(){
		Time.timeScale = 1f;
		pauseMenu.SetActive(false);
	}
	
	public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
