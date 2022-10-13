using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // For start menu
    public void StartButton(){
        SceneManager.LoadScene("Levels");
    }

    public void TutorialButton(){
        if (!StaticScript.operateInfoShowed)
        {
            StaticScript.showOperateInfo = true;
            StaticScript.operateInfoShowed = true;
        }
        SceneManager.LoadScene("Tutorial");
    }

    public void QuitButton(){
        Application.Quit();
    }
}
