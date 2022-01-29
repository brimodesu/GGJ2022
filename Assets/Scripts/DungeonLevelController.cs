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
        player._rangeWeapon.gameObject.SetActive(true);
        isometricCamera.Follow = player.transform;
    }

 
}
