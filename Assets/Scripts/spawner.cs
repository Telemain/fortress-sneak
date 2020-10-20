using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
	public Transform prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        StartCoroutine(spawnArmy());
    }
	IEnumerator spawnArmy(){
		
		yield return new WaitForSeconds(5);
		Instantiate(prefab, new Vector3(0, 2, -300), Quaternion.identity);
		//originally a bug the vast numbers of escapees was deemed a feature
	}
}
