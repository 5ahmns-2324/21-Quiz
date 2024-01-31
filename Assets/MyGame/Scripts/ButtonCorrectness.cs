using UnityEngine;
using UnityEngine.UI;

public class ButtonCorrectness : MonoBehaviour
{
    public Button answerButton;
    public bool answerIsRight;
    public Button weiterButton;


    private void Start()
    {
        answerButton.onClick.AddListener(ChangeButtonColor);
        weiterButton.interactable = false;
    }

    void ChangeButtonColor()
    {
        if (answerIsRight)
        {
            answerButton.image.color = Color.green;
            weiterButton.interactable = true;

        }
        else
        {
            answerButton.image.color = Color.red;
            weiterButton.interactable = true;
        }
    }
}