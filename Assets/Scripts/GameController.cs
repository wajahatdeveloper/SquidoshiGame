using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Controller<GameModel,GameView>
{
    public void OnClick_Play()
    {
        Debug.Log("Game Started");
        view.mainMenuPanel.SetActive(false);
        view.inGamePanel.SetActive(true);
    }

    public void OnClick_Exit()
    {
        Debug.Log("Game Exited");
        Application.Quit();
    }

    public void OnClick_Pause()
    {
        Debug.Log("Game Paused");
        view.pausePanel.SetActive(true);
    }

    public void OnClick_Resume()
    {
        Debug.Log("Game Resumed");
        view.pausePanel.SetActive(false);
    }
}