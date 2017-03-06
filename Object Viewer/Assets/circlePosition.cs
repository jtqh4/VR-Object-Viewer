using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlePosition : MonoBehaviour {
    public Camera camera;
    public GameObject obj;

    // Use this for initialization
    void Start () {

        SphereCollider objCollider = obj.GetComponent<LoadGameObj>().staticObj.GetComponent<SphereCollider>();

        Bounds b = objCollider.bounds;
        float radius = (objCollider.radius);
        Vector3 center = objCollider.center;
        transform.localScale += new Vector3(radius + (radius/4), radius + (radius / 4), 0);
        float CameraDistance = radius / Mathf.Tan(45F);
        transform.position = center;
        
    }

    // Update is called once per frame
    void Update () {
        transform.LookAt(camera.transform.position);
    }
}
