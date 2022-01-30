using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBosses : MonoBehaviour
{
    private FinalBossRoomController finalBossRoomController;
    private void Start()
    {
        finalBossRoomController = GameObject.FindObjectOfType<FinalBossRoomController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            finalBossRoomController.ActivateBosses();
        }
    }

  
}
