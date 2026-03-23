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
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = new Vector3(0, 0, 10f); // move forward
        }
    }
}