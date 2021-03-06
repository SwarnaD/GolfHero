﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    public GameObject arrow;
	public Transform ballTransform;

    private Transform arrowTransform;
    private Renderer arrowRends;
	private float camRotationY;

    private bool visible;

    // Use this for initialization
    void Start () {
        this.arrow = GameObject.Find("Arrow"); // init arrow var
		this.camRotationY = 0;
        this.arrowTransform = this.arrow.transform;
		this.arrowRends = this.arrow.GetComponent<Renderer> ();
        this.visible = true;
        //this.HideArrow();
    }
	
	// Update is called once per frame
	void Update () {
		this.camRotationY = this.transform.eulerAngles.y;
	}

	void LateUpdate () {
        if (ballTransform != null)
        {
			Vector3 offset = (arrowTransform.up * 3);
            arrowTransform.rotation = Quaternion.Euler(90, camRotationY + 90, 90);
            arrowTransform.position = ballTransform.position + offset;
        }
	}

    public void ShowArrow()
    {
        if (visible)
            return;

		arrowRends.enabled = true;

        visible = true;
    }

    public void HideArrow()
    {
        if (!visible)
            return;

		arrowRends.enabled = false;

        visible = false;
    }
}
