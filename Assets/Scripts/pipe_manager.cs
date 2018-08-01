using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_manager : MonoBehaviour
{
    public GameObject pipe;


    public void spawnpipe()
    {
        Vector3 randomPos;
        randomPos = new Vector3(4, Random.Range(-1.5f, 2), 0);
        GameObject realpipe = Instantiate(pipe, randomPos,Quaternion.identity);
    }




}
