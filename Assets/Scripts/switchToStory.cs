using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class switchToStory : MonoBehaviour {

    public GameObject videoPlayer;
    public GameObject canvas2;
    public GameObject canvas;
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        canvas2 = GameObject.Find("Canvas2");
        videoPlayer = GameObject.Find("Video Player");
        videoPlayer.SetActive(false);
        canvas.SetActive(false);
        if(vars.flag == 1)
        {
            canvas.SetActive(true);
            canvas2.SetActive(false);
            videoPlayer.SetActive(true);
            vars.flag = 0;
        }
    }



    
    void OnMouseDown()
    {
        StartCoroutine(vars.req.postReq());
        canvas2.SetActive(false);
        canvas.SetActive(true);
        videoPlayer.SetActive(true);
        

    }
}
