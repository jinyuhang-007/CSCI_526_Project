using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public void LoadGame()
    {
        StaticScript.success_or_fail=1;
        StaticScript.lines_drawn=GameObject.FindGameObjectsWithTag("Line").Length;
        StaticScript.timePrevious=StaticScript.timeElapsed;
        StaticScript.score = 0;
        StaticScript.timeLeft = 10;
        StaticScript.timerOn = false;
        StaticScript.enemies_killed=0;
        StaticScript.no_of_enemies = 3;
        StaticScript.level += 1;
        StaticScript.no_of_poops += 10;
        StaticScript.health = 100;
        Debug.Log("Level"+StaticScript.level.ToString());
        SceneManager.LoadScene("Level"+StaticScript.level.ToString());
    }

    public void LoadAgain()
    {
        StaticScript.success_or_fail=0;
        StaticScript.lines_drawn=GameObject.FindGameObjectsWithTag("Line").Length;
        StaticScript.timePrevious=StaticScript.timeElapsed;
        StaticScript.score = 0;
        StaticScript.timeLeft = 10;
        StaticScript.timerOn = false;
        StaticScript.enemies_killed=0;
        StaticScript.no_of_enemies = 3;
        StaticScript.level += 0;
        StaticScript.no_of_poops += 10;
        StaticScript.health = 100;
        if(StaticScript.level==0){
            SceneManager.LoadScene("Tutorial");
        }
        else{
            Debug.Log("Level"+StaticScript.level.ToString());
            SceneManager.LoadScene("Level"+StaticScript.level.ToString());
        }
        
    }

     public void LoadLevels()
    {
        StaticScript.timePrevious=StaticScript.timeElapsed;
        StaticScript.score = 0;
        StaticScript.timeLeft = 180;
        StaticScript.timerOn = false;
        StaticScript.no_of_poops = 10;
        StaticScript.health = 100;

        SceneManager.LoadScene("Levels");
    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
        StaticScript.level = 1;
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
        StaticScript.level = 2;
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
        StaticScript.level = 3;

    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level4");
        StaticScript.level = 4;
    }

    public void LoadBack()
    {
        SceneManager.LoadScene("RestartScene");

    }

    public void LoadMenu(){
        SceneManager.LoadScene("StartMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
