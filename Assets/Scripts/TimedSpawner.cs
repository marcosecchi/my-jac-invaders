using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    public bool shouldSpawn = true;

    public GameObject prefab;

    public float minSpawnTime = .5f;
    public float maxSpawnTime = 1.5f;
    public int waves = 4;

    public GameObject Player;

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
            var go = Instantiate(
                prefab, transform.position, transform.rotation);
            var nextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            go.transform.LookAt(Player.transform.position);
            Invoke("Spawn", nextSpawn);
            if(audio != null)
            {
                audio.Play();
            }
            waves--;
        }
    }
}
