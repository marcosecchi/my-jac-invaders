using UnityEngine;

public class RandomScaler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var scale = Random.Range(0.85f, 1.5f);
        transform.localScale = new Vector3(scale, scale, scale);
    }


}
