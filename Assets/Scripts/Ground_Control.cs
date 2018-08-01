using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Control : MonoBehaviour {

    Material asad;
    public float ScroolSpeed;
    private void Start()
    {
        asad = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        if (!Cute_BirdControl.isgameover)
        {
            Vector2 scrooloffset = asad.mainTextureOffset;
            scrooloffset.x += ScroolSpeed * Time.deltaTime;
            asad.mainTextureOffset = scrooloffset;
        }
    }
}
