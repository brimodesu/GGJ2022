using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestaurantLevelController : MonoBehaviour
{

    public GameController GameController;

    public int focus = 100;

    public Image focusImage;
    
    void Start()
    {
        StartCoroutine(DecreaseConcentration());
    }
    
    IEnumerator DecreaseConcentration()
    {
        while (!(focus < 0))
        {
            focus -= 10;
            focusImage.fillAmount = focus / 100f;
            if (focus < 0)
            {
                GameController.characterLostConcentration();
            }

            yield return new WaitForSeconds(1f);
        }
     
    }
}