using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBossRoomController : MonoBehaviour
{
    public List<GameObject> bosses;
    public ExplosionExplorer ExplosionExplorer;
    public void ActivateBosses()
    {
        foreach (var boss in bosses)
        {
            boss.SetActive(true);
        }

        StartCoroutine(ExplosionExplorer.StartExplosion());
    }
}