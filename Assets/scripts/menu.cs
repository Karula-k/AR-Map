using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadMap()
    {
        SceneManager.LoadScene("halaman map");
    }
    public void LoadProfile()
    {
        SceneManager.LoadScene("halaman films");
    }
    public void LoadAbout()
    {
        SceneManager.LoadScene("About");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
