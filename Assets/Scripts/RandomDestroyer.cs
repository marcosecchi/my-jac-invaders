using UnityEngine;

public class RandomDestroyer : MonoBehaviour
{
    [Range(0, 1.0f)]
    public float DestroyPercentage = .5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(Random.Range(0, 1.0f) < DestroyPercentage)
        {
            Destroy(gameObject);
        }
    }

}
