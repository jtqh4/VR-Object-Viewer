using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameObj : MonoBehaviour {
    public GameObject staticObj;
    public Camera camera;
	// Use this for initialization
    public SphereCollider getCollider()
    {
        return staticObj.GetComponent<SphereCollider>();
    }
    private void Awake()
    {
        print(PaneSelection.menuObj);
        print(PaneSelection.menuObj);
        if(PaneSelection.menuObj == "Cube")
        {
            staticObj = (GameObject)Instantiate(Resources.Load("squarePrefab"));

        } else if (PaneSelection.menuObj == "Boat")
        {
            staticObj = (GameObject)Instantiate(Resources.Load("boatPrefab"));

        }
        else
        {
            staticObj = (GameObject)Instantiate(Resources.Load("boatPrefab"));

        }
        staticObj.transform.position = new Vector3(0, 0, 0);
        staticObj.GetComponent<RayCast>().camera = camera;

    }

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
