using UnityEngine;

public class Weapon : MonoBehaviour
{
    // L'oggetto da sparare
    public GameObject prefab;

    public string buttonName = "Fire1";

    void Update()
    {
        if(Input.GetButtonDown(buttonName))
        {
            Instantiate(
                prefab, transform.position, transform.rotation);
        }

    }
}
