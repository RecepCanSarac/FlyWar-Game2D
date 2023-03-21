using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text skorTXT;
    private int skor;
    private void OnEnable()
    {
        EventManager.enemyDead += skorTxT;
    }

    private void OnDisable()
    {
        EventManager.enemyDead -= skorTxT;
    }

    private void skorTxT()
    {
        skor += 13;
    }

    private void Update()
    {
        skorTXT.text = skor.ToString();
    }
}
