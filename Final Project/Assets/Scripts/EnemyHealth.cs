using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
//using UnityEditor.UI;

//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;


using UnityEngine.SocialPlatforms.Impl;
//using UnityEngine.UIElements;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 8;
    public float currentHealth;



    public static int count = 0;
    public static int score = 0;
    public static int goal = 12;

    //singleton: can delete
    //public static EnemyHealth instance;
    //private int score = 0;

    //public static event Action OnVictory;

    [SerializeField] FloatingHealthBar floatingHB;


    void Awake()
    {
        floatingHB = GetComponentInChildren<FloatingHealthBar>();
        /* singleton: 
        if (instance == null)
         {
             instance = this;
             DontDestroyOnLoad(gameObject);
         }
         else
         {
             Destroy(gameObject);
         }

         SceneManager.sceneLoaded += OnSceneLoaded;
         */
    }

    void Start()
    {
        currentHealth = maxHealth;
        score = count;

        floatingHB.UpdateHealthBar(currentHealth, maxHealth);
    }

    /*  private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
      {
          score = 0;
      }
  */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            //TakeDamage(1);
            //player.karenDeaths += 1;

        }
    }

    void FixedUpdate()
    {

    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        floatingHB.UpdateHealthBar(currentHealth, maxHealth);



        if (currentHealth <= 0)
        {
            count++;
            score++;
            //Debug.Log(count);
            if (count == goal)
            {
                Debug.Log("PLANK");



            }
            Destroy(gameObject);

        }

    }

    public void BlueTakeDama(int damage)
    {
        maxHealth = 10;

    }


    /* public int GetScore()
     {
         return score;
     }
     */

}
