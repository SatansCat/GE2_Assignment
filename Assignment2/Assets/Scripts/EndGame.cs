﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Application.Quit()", 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
