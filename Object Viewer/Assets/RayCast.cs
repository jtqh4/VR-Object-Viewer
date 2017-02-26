using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {
    public Camera camera;
    

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update () {
        RaycastHit hit;
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);
        if (Physics.Raycast(ray, out hit))
        {

            if (hit.transform.name.Contains("circle_interface"))
            {


                float CameraDistance = transform.position.z - camera.transform.position.z;
                Vector3 CameraSightVector = camera.transform.position +
                    camera.transform.rotation * Vector3.forward * CameraDistance;

                transform.RotateAround(GetComponent<SphereCollider>().center, new Vector3(CameraSightVector.y - transform.position.y, transform.position.x - CameraSightVector.x, transform.position.z - CameraSightVector.z), 25* Time.deltaTime);



            }
        }
    }
}
