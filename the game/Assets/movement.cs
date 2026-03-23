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
        rb.linearVelocity = new Vector3(0, 0, 10f); // move forward
    }
}