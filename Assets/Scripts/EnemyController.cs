using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public ScriptableEnemy enemyData;

    public int currentHealth = 0;

    public event Action<int, int> OnHealthChanged;

    void Start()
    {
        changeHealth(enemyData.Health);
    }
    

    public void ReceiveDamage(int damageAmount)
    {
        var newHealth = Mathf.Max(currentHealth - damageAmount, 0);
        changeHealth(newHealth);
        if (newHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void changeHealth(int value)
    {
        currentHealth = value;
        OnHealthChanged?.Invoke(currentHealth, enemyData.Health);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            var player = collision.gameObject.GetComponent<PlayerController>();
            player.ReceiveDamage(enemyData.attack);
        }
        
    }
}