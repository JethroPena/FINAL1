using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class winnerHandler : MonoBehaviour
{
    public TextMeshProUGUI winnerPlayer;
    public int winnerNum;

    void Awake()
    {
        winnerNum = variableHandler.vPasser.winner;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Sheesh());
    }

    IEnumerator Sheesh()
    {
        if (winnerNum == 1)
        {
            winnerPlayer.text = variableHandler.vPasser.playerName1;
            variableHandler.vPasser.winner = 1;
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(4);
        }

        else
        {
            winnerPlayer.text = variableHandler.vPasser.playerName2;
            variableHandler.vPasser.winner = 2;
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(5);
        }
    }
}