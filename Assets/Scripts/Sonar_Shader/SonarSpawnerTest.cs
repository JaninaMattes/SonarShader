﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarSpawnerTest : MonoBehaviour
{
    public SonarStateTest state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // For debugging
        if (Input.GetMouseButtonDown(0))
        {
            // Takes mouse position and translates it into a ray
            // which then can be projected into 3D space
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // Overwrites the position of raycast with the following
                state.SonarOrigin = hit.point;
            }
        }
    }
}
