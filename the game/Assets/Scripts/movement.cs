using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb; // store it here

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector3(10f, 0, 10f); // move 
        }
        else if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector3(-10f, 0, 10f); // move 
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = new Vector3(0f, 0, 10f); // move 
        }
        else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector3(10f, 0, -10f); // move 
        }
        else if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector3(-10f, 0, 10f); // move 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = new Vector3(0f, 0, -10f); // move 
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector3(10f, 0, 0f); // move 
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector3(-10f, 0, 0f); // move 
        }
        else if (Input.GetKeyUp(KeyCode.W) & Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector3(-10f, 0, 0f); // move 
        }
        else if (Input.GetKeyUp(KeyCode.W) & Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector3(10f, 0, 0f); // move 
        }
        else
        {
            rb.linearVelocity = new Vector3(0f, 0, 0f); // move 
        }


    }
}