using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text text;

    public static int CoinCount { get { return PlayerPrefs.GetInt("Coins", 0); } set { PlayerPrefs.SetInt("Coins", value); } }

    private void Update()
    {
        text.text = CoinCount.ToString();
    }
}