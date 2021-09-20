using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        SceneManager.LoadScene("InGordo");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");

        Time.timeScale = 1f;
    }

}
