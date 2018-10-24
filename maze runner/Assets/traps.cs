using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traps : MonoBehaviour {

    public GameObject trapPrefab;
    bool trapActivated;
    public GameObject playerObj;

    //public Transform trapLauncher;

    private void Awake()
    {
        
    }

    // Use this for initialization
    void Start()
    {
      

    }
	
	// Update is called once per frame
	void Update ()
    {
        if(trapActivated == true)
        {

            Instantiate(trapPrefab, transform.position, Quaternion.identity);
            Debug.Log(" player has taken hectic amount of damage");
            Destroy(playerObj);
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trapActivated = true;
            Destroy(other);
        
            

        }
        else if (other.CompareTag("trap"))
        {
            trapActivated = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trapActivated = false;
        }

      
    }

  
   
}
