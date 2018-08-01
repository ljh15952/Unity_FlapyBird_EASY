using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour {

	public void Restartbt()
    {
        SceneManager.LoadScene("ingame");
        Cute_BirdControl.isgameover = false;
        Cute_BirdControl.isgamestart = false;
        Cute_BirdControl.Scorenum = 0;
    }
}
