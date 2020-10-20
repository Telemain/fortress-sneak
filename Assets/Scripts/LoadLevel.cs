using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{
	
	public string NextLevel = "Level2";
	//public string CurrentLevel;

	
	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter (Collider collider){
		
		SceneManager.LoadScene(NextLevel);
		
	}
	public void restart(){
		string scene = SceneManager.GetActiveScene().name.ToString();
		SceneManager.LoadScene( scene.ToString() );
	}
}
