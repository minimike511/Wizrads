﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minotaurBossRoom : MonoBehaviour
{
    private GameObject boss;
    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        boss = this.gameObject.transform.GetChild(0).gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !triggered)
        {
            triggered = true;
            boss.SetActive(true); //Maybe we can make this more ceremonious in the future
        }
    }
}
