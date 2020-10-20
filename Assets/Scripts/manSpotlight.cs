using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manSpotlight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Random.Range(95, 130), Random.Range(facing+90, facing+270)
        if (Input.GetKey("w") && 30 < transform.eulerAngles.x )
        {
			//transform.Rotate(2, 0, 0);
			transform.rotation = Quaternion.Euler(transform.eulerAngles.x - 0.5f, transform.eulerAngles.y, transform.eulerAngles.z);
        }

        if (Input.GetKey("s") && 85 > transform.eulerAngles.x)
        {
			//transform.Rotate(-2, 0, 0);
			transform.rotation = Quaternion.Euler(transform.eulerAngles.x + 0.5f, transform.eulerAngles.y, transform.eulerAngles.z);
        }
		if (Input.GetKey("d") && 350 > transform.eulerAngles.y)
        {
			//transform.Rotate(0, -2, 0);
			transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + 0.5f, transform.eulerAngles.z);
        }
        if (Input.GetKey("a") && 180 < transform.eulerAngles.y)
        {
			//transform.Rotate(0, 2, 0);
			transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y - 0.5f, transform.eulerAngles.z);
        }
		
		
    }
}
