using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_display : MonoBehaviour
{

    public float pipespeed=-0.04f;

    private void Update()
    {
        if(transform.position.x<-4)
        {
            Destroy(gameObject);
        }

        if (!Cute_BirdControl.isgameover)
            transform.position += new Vector3(pipespeed, 0, 0);
    }

}
