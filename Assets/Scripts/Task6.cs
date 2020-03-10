using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Task6 : MonoBehaviour {

    public GameObject Panel1, CluePanel, Cam;
    void Start()
    {
        /*Panel1 = GameObject.Find("Panel1");
        Panel2 = GameObject.Find("Panel2");
        Panel3 = GameObject.Find("Panel3");
        Panel4 = GameObject.Find("Panel4");
        Panel5 = GameObject.Find("Panel5");
        Panel6 = GameObject.Find("Panel6");
        videoPlayer = GameObject.Find("Video Player");
        CluePanel = GameObject.Find("CluePanel");
        Cam = GameObject.Find("ARCamera");*/
     
        CluePanel.SetActive(false);
        
    }
	
    public void story()
    {
        CluePanel.SetActive(false);
        Panel1.SetActive(true);
    }

    public void clue()
    {
        Panel1.SetActive(false);
        CluePanel.SetActive(true);

    }

    public void camera()
    {
        Panel1.SetActive(false);
        CluePanel.SetActive(false);
        vars.task++;
        SceneManager.LoadScene("Showdown");
    }
}
