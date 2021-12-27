using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : View
{
    public GameModel gameModel;
    public Image playerHp;

    public GameObject mainMenuPanel;
    public GameObject settingsPanel;
    public GameObject inGamePanel;
    public GameObject pausePanel;
    public GameObject exitPanel;

    private void Update()
    {
        playerHp.fillAmount = Mathf.InverseLerp(0, 100, gameModel.playerHp);
    }
}