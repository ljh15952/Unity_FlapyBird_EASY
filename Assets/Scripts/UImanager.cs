using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UImanager : MonoBehaviour {

    public GameObject rebt;

    public Text text;
    public Text Scoretext;
    public Text BestText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void ScoreUp(int score)
    {
        text.text = score.ToString();
        if(Cute_BirdControl.BestScorenum<Cute_BirdControl.Scorenum)
        {
            Cute_BirdControl.BestScorenum = Cute_BirdControl.Scorenum;
        }
    }

    public void ResultScore()
    {
        Scoretext.text = Cute_BirdControl.Scorenum.ToString();
        BestText.text = Cute_BirdControl.BestScorenum.ToString();
    }

    public void GameOverFunc()
    {
        Cute_BirdControl.isgameover = true;
        rebt.SetActive(true);
        ResultScore();
    }

}
