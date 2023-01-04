using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;
    public Text TimerTxt;
    public GameObject player;
    public GameObject reset;


    void Start()
    {
        TimerOn = true;
        player = GameObject.Find("Player");
        reset.gameObject.SetActive(false);
    }


    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
               
            }
            else
            {
                Debug.Log("Time is UP!");
                TimeLeft = 0;
                TimerOn = false;
                Destroy(player);
                reset.gameObject.SetActive(true);
                TimerTxt.text = string.Format("GOODNIGHT");
            }
        }
    }


    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }


}
