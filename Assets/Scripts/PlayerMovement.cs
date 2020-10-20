using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int moveSpeed;
	public Rigidbody rb;
	public bool isGrounded = true;

    void Start()
    {
        moveSpeed = 10;
		rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		//self righting
		var selfRightingTorque = 1.5f;
		var angle = Vector3.Angle(transform.up, Vector3.up);
		if(angle > 0.01f)
		{
			var axis = Vector3.Cross(transform.up, Vector3.up);
			GetComponent<Rigidbody>().AddTorque(axis * angle * selfRightingTorque);
		}
    
		if (Input.GetKey("w"))
        {
			//transform.position += transform.forward * 10 * Time.deltaTime;
			//rb.AddRelativeForce(Vector3.forward * 1);
			//rb.velocity += transform.forward * 2;
			if( Input.GetKey(KeyCode.LeftShift)){
				transform.position += transform.forward * 2 * moveSpeed * Time.deltaTime;
			}else{
				transform.position += transform.forward * moveSpeed * Time.deltaTime;
			}
			//GetComponent<Rigidbody>().AddTorque(transform.forward * 5);
        }

        if (Input.GetKey("s"))
        {
			transform.position += transform.forward * -10 * Time.deltaTime;
			//rb.AddRelativeForce(Vector3.forward * -10);
        }
		if (Input.GetKey("e"))
        {
			transform.position += transform.right * 10 * Time.deltaTime;
        }

        if (Input.GetKey("q"))
        {
			transform.position += transform.right * -10 * Time.deltaTime;
        }
		if (Input.GetKey("d"))
        {
			transform.Rotate(0, 50 * Time.deltaTime, 0);
        }
        if (Input.GetKey("a"))
        {
			transform.Rotate(0, -50 * Time.deltaTime, 0);
        }
		if (Input.GetKey("space") && isGrounded)
        {
			//transform.position += Vector3.up * moveSpeed * Time.deltaTime;
			//rb.velocity = new Vector3(0, 10, 0);
			rb.AddForce(new Vector3(0, 100, 0), ForceMode.Impulse);
            isGrounded = false;

		}
		if( Input.GetKeyDown(KeyCode.LeftControl) )
		{
			//transform.position += Vector3.down * 5 * Time.deltaTime;
			
			this.transform.localScale = new Vector3( this.transform.localScale.x, 1.0f, this.transform.localScale.z );
			this.transform.position = new Vector3( this.transform.position.x, 1.0f, this.transform.position.z );
			
		}else if( Input.GetKeyUp(KeyCode.LeftControl) ){
			
			this.transform.localScale = new Vector3( this.transform.localScale.x, 2.0f, this.transform.localScale.z );
			this.transform.position = new Vector3( this.transform.position.x, 2.0f, this.transform.position.z );
		}
		if (Input.GetKey("p")){
			this.GetComponent<Rigidbody>().useGravity = false;
			moveSpeed = 100;
			
		}
    }
	void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }
	}
}
