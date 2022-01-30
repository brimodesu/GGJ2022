using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBossRoomController : MonoBehaviour
{
    public List<GameObject> bosses;

    public void ActivateBosses()
    {
        foreach (var boss in bosses)
        {
            boss.SetActive(true);
        }
    }
}