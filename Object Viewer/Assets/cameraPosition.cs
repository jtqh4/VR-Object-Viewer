using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPosition : MonoBehaviour {
    public OVRCameraRig camera;
    public GameObject obj;
    // Use this for initialization
    void Start () {
        SphereCollider objCollider = obj.GetComponent<SphereCollider>();
        Bounds b = objCollider.bounds;

        float radius = (objCollider.radius);
        Vector3 center = objCollider.center;
        float CameraDistance = radius / Mathf.Tan(10F);

        camera.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z-CameraDistance);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
