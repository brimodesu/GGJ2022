using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Restaurant 1");
    }

    public void HandlePanelVisibilty( GameObject panel)
    {
        panel.gameObject.SetActive(!panel.gameObject.activeInHierarchy);
    }
}
