﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCamController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        // this object was clicked - do something
        Destroy(this.gameObject);
    }
}
