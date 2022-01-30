using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class DungeonLevelController : MonoBehaviour
{

    public CinemachineVirtualCamera isometricCamera;
    public PlayerController player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        GameObject weapon = player._rangeWeapon.gameObject;
        weapon.SetActive(true);
        weapon.transform.SetParent(player._playerModel.weaponSpawn,true);
        weapon.transform.position = player._playerModel.weaponSpawn.transform.position;
        isometricCamera.Follow = player.transform;
    }

 
}
