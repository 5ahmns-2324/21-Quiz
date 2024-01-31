using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{

    public string[] sceneNames; 

    public void LoadRandomScene()
    {
        int randomIndex = Random.Range(0, sceneNames.Length); 
        string sceneToLoad = sceneNames[randomIndex];
        SceneManager.LoadScene(sceneToLoad);
    }



}


    /*

    Szenen in richtiger Reihenfolge abrufen:


    public void LoadScene()
    {
        SceneManager.LoadScene("Question2");
    }


    */
