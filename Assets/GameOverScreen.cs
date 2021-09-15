using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{

    public Text pointTextK;
    public Text pointTextM;

    public void SetUp(int scoreK,int scoreM)
    {
        gameObject.SetActive(true);
        pointTextK.text = scoreK.ToString();
        pointTextM.text = scoreM.ToString();
;
    }

    public void RestartButton()
    {
        Application.LoadLevel("InGordo");
    }

    public void ExitButton()
    {
        Application.LoadLevel("Main Menu");
    }

}
