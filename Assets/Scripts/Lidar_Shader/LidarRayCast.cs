using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidarRayCast : MonoBehaviour
{
    public float TargetDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        // sending a raycast and out receives the raycast distance
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            TargetDistance = Hit.distance;
        }
    }
}
