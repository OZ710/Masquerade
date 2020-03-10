using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Showdown : MonoBehaviour
{

    public GameObject canvas;
    public VideoPlayer videoPlayer;
    public AudioSource audioSource;
    void Start()
    {
        Debug.Log("lala");
        videoPlayer.Pause();
        canvas.SetActive(false);
       
    }
 
}
