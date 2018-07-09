using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {
    public GameObject depthMashObject;
    public bool meshIsMasking = true;

	
	public void OnButtonPress()
    {
        if (meshIsMasking)
        {
            depthMashObject.SetActive(false);
            meshIsMasking = false;
            return;
        }
        else
        {
            depthMashObject.SetActive(true);
            meshIsMasking = true;
        }

    }
	// Update is called once per frame
	void Update () {
		
	}
}
