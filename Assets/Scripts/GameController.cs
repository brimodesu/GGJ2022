using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{


    [SerializeField] private float currentPlayerMoney = 0f;
    public TMP_Text _currentMoney;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateMoney( float money)
    {
        currentPlayerMoney += money;
        _currentMoney.text = $"Q {currentPlayerMoney.ToString("0,0.00")}";
    }
}
