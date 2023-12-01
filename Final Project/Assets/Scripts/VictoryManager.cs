using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryManager : MonoBehaviour
{
    public GameObject victoryMenu;


    //Vicotry Screen
    private void OnEnable()
    {
        capsule.OnVictory += EnableVictoryMenu;
    }

    private void OnDisable()
    {
        capsule.OnVictory -= EnableVictoryMenu;
    }

    public void EnableVictoryMenu()
    {
        victoryMenu.SetActive(true);
    }

    public void MainMenu()
    {
        //EnemyHealth.count = 0;
        SceneManager.LoadScene("MainMenu");

    }

    public void NextLevelDay1()
    {
        SceneManager.LoadScene(1);
    }

    public void NextLevelDay2()
    {
        // EnemyHealth.count = 0;
        SceneManager.LoadScene("Day2.1");
        DayTracker.Instance.ResetData();
    }
    public void NextLevelDay3()
    {
        SceneManager.LoadScene("Day3");
    }
    public void NextLevelDay4()
    {
        SceneManager.LoadScene(4);
    }
}
