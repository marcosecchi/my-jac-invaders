using UnityEngine;

public class ProjSpeed : MonoBehaviour
{
    public Rigidbody _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 vector = transform.forward * 60;
          _rb.linearVelocity = vector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
