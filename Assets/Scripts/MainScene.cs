using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour {
    
    public void play()
    {
        SceneManager.LoadScene("Login");
    }
    public void exit()
    {
        Application.Quit();
    }
}
