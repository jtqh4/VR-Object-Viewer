using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {
    private OVRCameraRig self_camera;
    private bool down;
    
	// Use this for initialization
	void Start () {
        down = false;
        self_camera = this.GetComponent<OVRCameraRig>();
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            down = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            down = false;
        }
        if (down)
        {
            transform.position = transform.position + self_camera.centerEyeAnchor.transform.rotation * Vector3.forward * 1/10;
        }
    }
}
