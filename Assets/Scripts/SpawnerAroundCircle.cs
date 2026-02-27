using UnityEngine;

public class SpawnerAroundCircle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var coords = Random.onUnitSphere * 100;
        var finalCoords = new Vector3(coords.x, 0, coords.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
