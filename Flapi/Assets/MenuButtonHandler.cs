using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonHandler : MonoBehaviour
{
    //ass
    public void StartButtonClick()
    {
        SceneManager.LoadScene(1);   
    }

    public void QuitButtonClick()
    {
        Application.Quit();
    }
}
