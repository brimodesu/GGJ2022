using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    

    [SerializeField] private float currentPlayerMoney = 0f;
    public TMP_Text _currentMoney; 
    public bool playerCanShoot = false;


    public GameObject space;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void updateMoney( float money)
    {
        currentPlayerMoney += money;
        if (money <= 0)
        {
            _currentMoney.color = Color.red;
        }

        _currentMoney.text = $"Q {currentPlayerMoney.ToString("0,0.00")}";
    }

    public void characterLostConcentration()
    {
        SceneManager.LoadScene("SampleScene",LoadSceneMode.Additive);
        playerCanShoot = true;
        space.SetActive(true); 

    }
}
