using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeText : MonoBehaviour
{
    public GameObject timeText;

    private DateTime currentTime;

    private void Update()
    {
        SetTimeTextNow();
    }

    private void SetTimeTextNow()
    {
        currentTime = DateTime.Now;
        timeText.GetComponent<UnityEngine.UI.Text>().text = currentTime.ToString("HH:mm:ss");
    }

}
