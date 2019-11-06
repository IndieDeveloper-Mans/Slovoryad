using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimeManage : MonoBehaviour
{
    public float timer = 30f;
    public TextMeshProUGUI time;
    public Slider timeSlider;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        int intTime = Mathf.RoundToInt(timer);

        time.text = intTime.ToString();

        timeSlider.value = intTime;

        if (timer < 0 )
        {
            timer = 0f;
            TimeLeft();
        }
    }

    private void TimeLeft()
    {

    }
}
