using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ShipController : MonoBehaviour
{
    public float rotatioSpeed = 100.0f;
    public float moveForce = 5.0f;

    Rigidbody _rb;

    void Start()
    {
        // Recupero il componente rigidbody
        // che è sicuramente presente perché lo ho dichiarato
        // con RequireComponent
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var hMove = Input.GetAxis("Horizontal");
        var vMove = Input.GetAxis("Vertical");

        // Applico una rotazione all'astronave
        var rotation = hMove * Time.deltaTime * rotatioSpeed;
        transform.Rotate(0, rotation, 0);

        // Calcolo la forza di movimento in avanti
        var move = vMove * moveForce;
        var force = transform.forward * move;
        // Applico la forza
        _rb.AddForce(force);

    }
}
