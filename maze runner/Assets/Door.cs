using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    //public BoxCollider doorTrigger;
    public bool isSteppedOn;
    //public Animator anim;
    public GameObject door;

        // Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
       // anim = GetComponent<Animator>();

        if (isSteppedOn == true)
        {
            Destroy(door);
            Debug.Log(" the trigger has been set off, door will open...");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isSteppedOn = true;
        }
       
    }
}
