﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float speed;

	void Update ()
    {
        this.transform.Rotate(Vector3.left, speed * Time.deltaTime);
	}
}
