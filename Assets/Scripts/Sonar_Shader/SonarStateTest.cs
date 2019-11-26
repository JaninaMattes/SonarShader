﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarStateTest : MonoBehaviour
{
    // Properties
    public float speed;
    public Material material;
    private Vector4 sonarOrigin = Vector4.one;

    // Setter and Getter
    public Vector3 SonarOrigin { set { sonarOrigin = new Vector4(value.x, value.y, value.z, 0); } }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // If sonar ring exceedes one it gets reduced 
        // so that colors are not inverted
        sonarOrigin.w = Mathf.Min(sonarOrigin.w + (Time.deltaTime * speed), 1);
        material.SetVector("_SonarOrigin", sonarOrigin);
    }
}
