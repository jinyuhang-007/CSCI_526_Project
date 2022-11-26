using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PauseScreen;
    public GameObject Hint;
    int hint_time;

    public Slider HealthBar;
    public TMP_Text BulletNumber;
    public TMP_Text LineNumber;
    public TMP_Text EraserNumber;
    public TMP_Text Score;

    void Start()
    {
        Hint.SetActive(false);
        PauseScreen.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) TogglePause();
        UpdateUI();
    }

    void FixedUpdate()
    {
        if (Hint.activeSelf)
        {
            hint_time -= 1;
            if (hint_time == 0)
            {
                Hint.SetActive(false);
            }
        }
    }

    void UpdateUI()
    {
        HealthBar.value = StaticScript.health;
        BulletNumber.text = "x" + StaticScript.no_of_poops.ToString();
        LineNumber.text = "x " + (StaticScript.lines_limit - StaticScript.lines_drawn).ToString();
        EraserNumber.text = "x " + StaticScript.no_of_erasers.ToString();
        Score.text = "score = " + StaticScript.score.ToString();
    }

    public void ShowHint()
    {
        Hint.SetActive(true);
        hint_time = 200;
    }

    public void TogglePause()
    {
        if (GamePaused) Resume();
        else Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0;
        PauseScreen.SetActive(true);
        GamePaused = true;
    }


    public void Resume()
    {
        Time.timeScale = 1;
        PauseScreen.SetActive(false);
        GamePaused = false;
    }
}
