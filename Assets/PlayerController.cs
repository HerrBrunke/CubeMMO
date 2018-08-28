using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Quaternion rotationspeed;
    public float playerSpeed = 20f;
	// Use this for initialization
	void Start () {
        //
        //rotationspeed = Vector3.left;
	}
	
	// Update is called once per frame
	void Update () {
        /* if (Input.GetKey("up")) {
             transform.position += Vector3.forward * Time.deltaTime; 
         }
         if (Input.GetKey("down")) {
             transform.position += Vector3.back * Time.deltaTime;
         }
         if (Input.GetKey("left"))
         {
             transform.rotation = transform.rotation * Vector3.left * Time.deltaTime;
         }
         if (Input.GetKey("right")) {

         }*/
        if (Input.GetKeyDown("w")) {

           transform.position += playerSpeed * Time.deltaTime * Vector3.up;
        }else if (Input.GetKeyDown("s")){
            transform.position += playerSpeed * Time.deltaTime * Vector3.down;
        }
    }
}
