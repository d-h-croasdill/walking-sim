﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COL : MonoBehaviour
{
    public float timer;

    void Start()
    {

    }

    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if (timer <= 0)
            Destroy(this.gameObject);
    }

    void DestroyCOL()
    {
        Destroy(this.gameObject);
    }
}