using JetBrains.Annotations;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyAI : MonoBehaviour
{
    public GameObject player;

    Rigidbody _rb;

    public bool seekAndDestroy = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;

        if (seekAndDestroy || transform.position.z > player.transform.position.z + 5)
        {
            transform.LookAt(player.transform.position);
        }
        _rb.AddForce(transform.forward * 1f);

    }
}
