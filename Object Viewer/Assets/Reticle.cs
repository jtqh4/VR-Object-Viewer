﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticle : MonoBehaviour {
    public Camera CameraFacing;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(CameraFacing.transform.position);
        transform.Rotate(0.0f, 180.0f, 0.0f);
        transform.localScale = new Vector3(0.1025159F, 0.09258702F, 1);
        transform.position = CameraFacing.transform.position +
            CameraFacing.transform.rotation * Vector3.forward * 2;
	}
}
