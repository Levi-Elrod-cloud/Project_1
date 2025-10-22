using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;

    public int myNumber = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello, World");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("My number is " + myNumber);
        //Adds 1 every frame to myNumber
        //myNumber += 1;
        transform.Translate(0 , 0, 2 * Time.deltaTime * speed);
    }
}
