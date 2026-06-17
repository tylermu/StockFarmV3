using UnityEngine;

public class IsometricZ : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y/100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
