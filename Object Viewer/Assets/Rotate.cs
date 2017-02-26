using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public Camera CameraFacing;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float CameraDistance = transform.position.z - CameraFacing.transform.position.z;
        Vector3 CameraSightVector = CameraFacing.transform.position +
            CameraFacing.transform.rotation * Vector3.forward * CameraDistance;
        
        transform.Rotate(CameraSightVector.y - transform.position.y, transform.position.x - CameraSightVector.x, transform.position.z - CameraSightVector.z, Space.World);

    }
}
