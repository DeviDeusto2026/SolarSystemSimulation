using UnityEngine;

public class RotatingSun : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float sunSpeed;
    void Start()
    {
        sunSpeed = -200;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation *= Quaternion.Euler(0, 1 * Time.deltaTime * sunSpeed, 0);
    }
}
