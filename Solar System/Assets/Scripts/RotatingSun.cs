using UnityEngine;

public class RotatingSun : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation *= Quaternion.Euler(0, 0, 0);
    }
}
