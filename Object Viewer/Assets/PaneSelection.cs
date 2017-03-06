using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaneSelection : MonoBehaviour {
    public Camera camera;
    public static string menuObj;
    // Use this for initialization
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update () {
        RaycastHit hit;
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name.Contains(transform.name))
            {
                if(Input.GetMouseButtonDown(0))
                {

                    if (menuObj == null)
                    {
                        menuObj = hit.transform.name;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("SceneSelection", UnityEngine.SceneManagement.LoadSceneMode.Single);
                    }
                    else
                    {
                        if(hit.transform.name == "RotationSelection")
                        {
                            UnityEngine.SceneManagement.SceneManager.LoadScene("RotateRing", UnityEngine.SceneManagement.LoadSceneMode.Single);

                        }
                        else if(hit.transform.name == "AnimationSelection")
                        {
                            UnityEngine.SceneManagement.SceneManager.LoadScene("Animation", UnityEngine.SceneManagement.LoadSceneMode.Single);

                        }
                        else
                        {
                            UnityEngine.SceneManagement.SceneManager.LoadScene("StartMenu", UnityEngine.SceneManagement.LoadSceneMode.Single);

                        }
                    }

                }
                else
                {
                    transform.GetComponent<Renderer>().material.color = Color.yellow;

                }

            }
            else
            {
                transform.GetComponent<Renderer>().material.color = Color.black;

            }
        }
        else
        {
            transform.GetComponent<Renderer>().material.color = Color.black;

        }
    }
}
