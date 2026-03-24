using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public GameObject OpenDoor;
    public GameObject ClosedDoor;
    public bool InRadius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(InRadius == true) 
        {
            if(Input.GetKey(KeyCode.E))
            {
                OpenDoor.SetActive(true);
                ClosedDoor.SetActive(false);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        InRadius = true;
    }

    private void OnTriggerExit(Collider other)
    {
        InRadius = false;
    }
}
