using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimations : MonoBehaviour {

    public Animation anim;
    void Start()
    {
        anim = GetComponent<LoadGameObj>().staticObj.GetComponent<Animation>();
        if (anim != null)
        {
            anim.Play();
            foreach (AnimationState state in anim)
            {
                state.speed = 1;
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
