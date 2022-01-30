using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public ScriptableEnemy enemyData;
    
    public int currentHealth= 0;

    public event Action<int, int> OnHealthChanged;
    
    void Start()
    {
        changeHealth(enemyData.Health);
    }

    private void Update()
    {
    }

    public void ReceiveDamage(int damageAmount)
    {
        changeHealth( Mathf.Max(currentHealth - damageAmount, 0));
    }

    public void changeHealth(int value)
    {
        currentHealth = value;
        OnHealthChanged?.Invoke(currentHealth, enemyData.Health);
    }
    
}
