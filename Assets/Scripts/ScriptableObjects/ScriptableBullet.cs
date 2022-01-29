using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableBullet", menuName = "ScriptableObjects/Bullet")]
public class ScriptableBullet : ScriptableObject
{
    public GameObject prefab;
    public int damage = 5;
    public float speed = 5f;
}
