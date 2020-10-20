using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public GameObject target;
    public float speed = 1000.0f;
	Vector3 offset;
	//public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        //Car = GameObject.Find("Car");
		//transform.rotation = Quaternion.Euler(42, -90, 0);
		offset = target.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		speed = 10.0f;
        //transform.position = new Vector3( Mathf.Lerp(transform.position.x, Car.transform.position.x + 0, 0.05f) , Mathf.Lerp(transform.position.y, Car.transform.position.y + 5, 0.05f), Mathf.Lerp(transform.position.z, Car.transform.position.z + 20 , 0.05f)); 
		
		//transform.rotation = Quaternion.Slerp( transform.rotation, Car.transform.rotation, 0.1f);
		//transform.eulerAngles = new Vector3( Car.transform.eulerAngles.x + 90, Car.transform.eulerAngles.y + 180, Car.transform.eulerAngles.z);
		//Debug.Log(Car.transform.eulerAngles.y);
		
		 // Look
        var newRotation = Quaternion.LookRotation(target.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, speed * Time.deltaTime);

        // Move
        Vector3 newPosition = target.transform.position - target.transform.forward * offset.z - target.transform.up * offset.y;
        transform.position = Vector3.Slerp(transform.position, newPosition, Time.deltaTime * speed);
    
    
	}
}
