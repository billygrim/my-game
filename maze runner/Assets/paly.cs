using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paly : MonoBehaviour {

    public Camera cam;
    public float speed;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal= Input.GetAxis("Horizontal");
        float veritcal = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0, 0, veritcal);
        Vector3 rotation = new Vector3(0, horizontal, 0);

        transform.Translate(movement * Time.deltaTime * speed);
        transform.Rotate(rotation * Time.deltaTime * rotationSpeed);
	}
}
