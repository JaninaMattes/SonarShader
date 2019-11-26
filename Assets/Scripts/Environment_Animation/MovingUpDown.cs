using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUpDown : MonoBehaviour
{
    public float speed = 2.0f;
    public float height = 0.5f;
    private Vector3 pos = new Vector3(0, 0, 0);

    private void Start()
    {
        // Get the current objects possition
        pos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        // Calculate the new Y-position
        float y_position = Mathf.Sin(Time.time * speed) * height + pos.y;
        // Set the objects y to the calculatet y-position
        transform.position = new Vector3(pos.x, y_position, pos.z) * height;

        Debug.Log("Position y: " + y_position);
    }
}
