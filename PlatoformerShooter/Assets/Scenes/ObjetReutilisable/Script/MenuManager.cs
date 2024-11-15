using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void ChangerScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TestLevel");
    }

    public void Jouer()
    {
        Debug.Log("Jouer");
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
