using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    public bool shouldSpawn = true;

    public GameObject prefab;

    public float minSpawnTime = .5f;
    public float maxSpawnTime = 1.5f;
    public int waves = 4;

    public AudioSource audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Spawn", 1);
    }

    void Spawn()
    {
        if(shouldSpawn && waves > 0)
        {
            Instantiate(
                prefab, transform.position, transform.rotation);
            var nextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            Invoke("Spawn", nextSpawn);
            audio.Play();
            waves--;
        }
    }
}
