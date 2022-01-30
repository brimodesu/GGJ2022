using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{


    [SerializeField] private float currentPlayerMoney = 0f;
    public TMP_Text _currentMoney;


    public void updateMoney( float money)
    {
        currentPlayerMoney += money;
        _currentMoney.text = $"Q {currentPlayerMoney.ToString("0,0.00")}";
    }

    public void characterLostConcentration()
    {
        SceneManager.LoadScene("SampleScene",LoadSceneMode.Additive);
        
        
    }
}
