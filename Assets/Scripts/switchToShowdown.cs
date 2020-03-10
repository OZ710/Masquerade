using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchToShowdown: MonoBehaviour {

    public GameObject cam;
    public GameObject canvas;
    public GameObject videoPlayer;
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        cam = GameObject.Find("Canvas2");
        videoPlayer.SetActive(false);
        canvas.SetActive(false);
    }
    

}
