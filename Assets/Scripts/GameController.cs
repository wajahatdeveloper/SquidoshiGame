using BehaviorDesigner.Runtime;
using GameCreator.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : Controller<GameModel,GameView>
{
    public Actions restorePlayer;

    public GameObject gameView;
    public GameObject losePanel;
    public Text coinsEarnedWin;
    public Text coinsEarnedLose;
    public GameObject winPanel;

    public GameObject smallMonsterFight;
    public GameObject mediumMonsterFight;
    public GameObject largeMonsterFight;

    public int monsterFightIndex = 0;

    public void OnClick_Play()
    {
        Debug.Log("Game Started");
        view.mainMenuPanel.SetActive(false);
        view.inGamePanel.SetActive(true);
        gameView.SetActive(true);
        StartMonsterFight_Small();
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

    public void OnClick_Retry()
    {
        // Restart Current Fight
    }

    public void StartMonsterFight_Small()
    {
        monsterFightIndex = 1;
        smallMonsterFight.SetActive(true);
    }

    public void StartMonsterFight_Medium()
    {
        monsterFightIndex = 2;
        mediumMonsterFight.SetActive(true);
    }

    public void StartMonsterFight_Large()
    {
        monsterFightIndex = 3;
        largeMonsterFight.SetActive(true);
    }

    public void OnMonsterKilled(GameObject monster)
    {
        monster.GetComponent<BehaviorTree>().DisableBehavior();
        monster.GetComponent<Animator>().Play("Dead");
        NextFight();
    }

    public void OnWin()
    {
        coinsEarnedWin.text = "Coins Earned: " + 999;
        winPanel.SetActive(true);
    }

    public void NextFight()
    {
        ResetFight();

        if (monsterFightIndex == 1)
        {
            StartMonsterFight_Medium();
        }
        else if (monsterFightIndex == 2)
        {
            StartMonsterFight_Large();
        }
        else if (monsterFightIndex == 3)
        {
            OnWin();
        }
    }

    private void ResetFight()
    {
        // reset player hp
        model.playerHp = 100;
        restorePlayer.Execute();
        // disable previous fights
        smallMonsterFight.SetActive(false);
        mediumMonsterFight.SetActive(false);
        largeMonsterFight.SetActive(false);
    }

    public void OnLose()
    {
        coinsEarnedLose.text = "Coins Earned: " + 999;
        losePanel.SetActive(true);
    }
}