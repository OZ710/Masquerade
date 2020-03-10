using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class Task1 : MonoBehaviour {
    
    public VideoPlayer videoPlayer;
    
    public GameObject Panel1, Panel2,cluePanel,canvas,canvas2,videoplayer;
    void Start()
    {
       
        Panel1 = GameObject.Find("Panel");
        Panel2 = GameObject.Find("Panel1");
        cluePanel = GameObject.Find("CluePanel");
        Panel2.SetActive(false);
        Panel1.SetActive(false);

       

    }

    

	public void next()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(true);
    }

    public void previous()
    {
        Panel2.SetActive(false);
        Panel1.SetActive(true);
    }

    public void camera()
    {
        Panel2.SetActive(false);
        cluePanel.SetActive(false);
        vars.task++;
        
        SceneManager.LoadScene("Task2");

    }

    public void story()
    {
        cluePanel.SetActive(false);
        Panel1.SetActive(true);
        videoPlayer.Pause();
    }
    public void clue()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        cluePanel.SetActive(true);
        videoPlayer.Play();
    }
}
