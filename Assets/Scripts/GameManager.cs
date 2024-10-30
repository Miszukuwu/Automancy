using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int playerMoney = 1000;
    public static bool isUiOpen = false;
    public static Sprite[] graveSprites;

    private void Start()
    {
        graveSprites = Resources.LoadAll<Sprite>("Graves");
    }
}
