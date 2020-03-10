using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraback : MonoBehaviour {

	// Use this for initialization
	public GameObject canvas1, canvas2;

	public void cback()
    {
		
		if (vars.task == 1)
        {
			SceneManager.LoadScene("MainScene");
		}
		else
        {
			vars.flag = 1;
			vars.task--;
			SceneManager.LoadScene("Task" + vars.task);
		}	
    }

	void Start () {
		
	}
	
	// Update is called once per frame
}
