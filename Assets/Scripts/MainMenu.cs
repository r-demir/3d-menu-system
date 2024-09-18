using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel;
    public GameObject optionsMenu;

    public void Play() {
        SceneManager.LoadScene(firstLevel);
    }

    public void OpenOptions() {
        optionsMenu.SetActive(true);
    }

    public void CloseOptions() {
        optionsMenu.SetActive(false);
    }

    public void Quit() {
        Debug.Log("MainMenu: quit clicked");
        Application.Quit();
    }

}
