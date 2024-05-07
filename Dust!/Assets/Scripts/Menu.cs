using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject pausePanel, gameUI, waveName, mainMenu, credits, panel1, panel2, panel3, panel4;

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void P1toP2()
    {
        panel2.SetActive(true);
        panel1.SetActive(false);
    }

    public void P2toP3()
    {
        panel3.SetActive(true);
        panel2.SetActive(false);
    }

    public void P3toP4()
    {
        panel4.SetActive(true);
        panel3.SetActive(false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Pausar()
    {
        Time.timeScale = 0f;
        waveName.SetActive(false);
        gameUI.SetActive(false);
        pausePanel.SetActive(true);
        
    }

    public void BackToGame()
    {
        Time.timeScale = 1.0f;
        gameUI.SetActive(true);
        pausePanel.SetActive(!true);
        waveName.SetActive(true);
    }

    public void OpenCredits()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }
    public void CloseCredits()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
