using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy",menuName = "ScriptableObjects/Enemy")]
public class ScriptableEnemy : ScriptableObject
{
    public int Health = 100;
    public int attack = 200;
    
}
