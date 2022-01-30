using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class ExplosionExplorer : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public RawImage explotionImage;

    public IEnumerator StartExplosion()
    {
        yield return new WaitForSeconds(10);
        explotionImage.gameObject.SetActive(true);
        VideoPlayer.Play();
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainScene");
    }
}