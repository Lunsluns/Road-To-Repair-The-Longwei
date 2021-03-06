﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_ONCE : MonoBehaviour
{
    [SerializeField]
    GameObject switchs;

    [SerializeField]
    GameObject platform;

    void Update()
    {

        if (switchs.GetComponent<Switch>().isOn == true)
        {
            platform.GetComponent<MovePlatform>().isOn = true;
        }
        if (platform.GetComponent<MovePlatform>().atEnd == true)
        {
            platform.GetComponent<MovePlatform>().isOn = false;
            switchs.GetComponent<Switch>().isOn = false;
        }

    }
}