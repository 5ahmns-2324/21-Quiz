using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomButtonOrder : MonoBehaviour
{
    public Button[] buttons;

    void Start()
    {
        RandomizeButtons();
    }

    void RandomizeButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int randomIndex = Random.Range(0, buttons.Length);
            Vector3 tempPos = buttons[i].transform.position;
            buttons[i].transform.position = buttons[randomIndex].transform.position;
            buttons[randomIndex].transform.position = tempPos;
        }
    }
}