using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountingDown : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float setTime = 60f;

    private float currentTime;

    void Start()
    {
        currentTime = setTime;
    }

    void Update()
    {
        if (currentTime >= 0)
        {
            currentTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(currentTime / 60);
            int seconds = Mathf.FloorToInt(currentTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            currentTime = 0;
        }
    }
}
