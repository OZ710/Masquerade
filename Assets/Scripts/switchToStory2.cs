using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchToStory2 : MonoBehaviour {

    public GameObject cam;
    public GameObject canvas;
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        cam = GameObject.Find("Canvas2");
        
        if (vars.flag == 1)
        {
            canvas.SetActive(true);
            cam.SetActive(false);
            vars.flag = 0;
        }

        else
        {
            canvas.SetActive(false);
        }
    }
    

    
	void OnMouseDown()
    {
        StartCoroutine(vars.req.postReq());
        cam.SetActive(false);
        canvas.SetActive(true);
        
    }
}
