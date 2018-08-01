using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_timer : MonoBehaviour {

    public pipe_manager pipem;
    public float wordDelay = 1.5f;
    private float nextWordTime = 0;

    private void Start()
    {
        nextWordTime = Time.time + wordDelay;
    }

    private void Update()
    {
        if (Time.time >= nextWordTime&&!Cute_BirdControl.isgameover&& Cute_BirdControl.isgamestart)
        {
            pipem.spawnpipe();
            nextWordTime = Time.time + wordDelay;
        }
    }
}
