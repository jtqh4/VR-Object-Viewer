using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPosition : MonoBehaviour {
    public OVRCameraRig camera;
    public GameObject obj;
    // Use this for initialization
    void Start () {

        SphereCollider objCollider = obj.GetComponent<LoadGameObj>().staticObj.GetComponent<SphereCollider>();
        Bounds b = objCollider.bounds;

        float radius = (objCollider.radius);
        Vector3 center = objCollider.center;
        float CameraDistance = radius / 0.176F;


        camera.transform.position = new Vector3(0, 0, 0 - CameraDistance);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
