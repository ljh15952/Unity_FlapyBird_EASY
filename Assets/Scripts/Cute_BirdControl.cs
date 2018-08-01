using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cute_BirdControl : MonoBehaviour {

    public float jump;
    public GameObject Cute_Bird;
    Rigidbody2D birdrb;

    public GameObject HI;

    public GameObject click;

    public UImanager UIM;


    public static int Scorenum;
    public static int BestScorenum;

    public static bool isgameover = false;

    public static bool isgamestart = false;

    private void Start()
    {
        birdrb = GetComponent<Rigidbody2D>();
        birdrb.gravityScale = 0;
    }

    void Update ()
    {
	    if((Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))&&!isgameover)
        {
            if (!isgamestart)
            {
                birdrb.gravityScale = 1;
                click.SetActive(false);
                isgamestart = true;
            }
            else
            {
                birdrb.velocity = Vector2.up * jump;
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
        }
        else if(isgamestart)
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, birdrb.velocity.y > 0 ? 45 : -80), 300 * Time.fixedDeltaTime); //떨어지고있을때 velocity.y 0보다작으면 떨어지는거

	}


    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pipe"))
        {
            if (collision.gameObject.name == "ScoreUp")
            {
                UIM.ScoreUp(++Scorenum);
                HI.GetComponent<PLZNUMBERSEX>().sex();
            }
            else
                UIM.GameOverFunc();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
            UIM.GameOverFunc();
    }


   
}
