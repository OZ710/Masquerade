using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Task5 : MonoBehaviour {

    public GameObject Panel1, Panel2, Panel3, Panel4, Panel5, Panel6, Panel7, CluePanel, Cam;
    void Start()
    {
  
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        CluePanel.SetActive(false);
    }
	public void next1()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(true);
       
    }

    public void previous2()
    {
        Panel2.SetActive(false);
        Panel1.SetActive(true);
    }

    public void next2()
    {
        Panel2.SetActive(false);
        Panel3.SetActive(true);
    }

    public void previous3()
    {
        Panel3.SetActive(false);
        Panel2.SetActive(true);
    }

    public void next3()
    {
        Panel3.SetActive(false);
        Panel4.SetActive(true);
    }

    public void previous4()
    {
        Panel4.SetActive(false);
        Panel3.SetActive(true);
    }

    public void next4()
    {
        Panel4.SetActive(false);
        Panel5.SetActive(true);
    }

    public void previous5()
    {
        Panel5.SetActive(false);
        Panel4.SetActive(true);
    }

    public void next5()
    {
        Panel5.SetActive(false);
        Panel6.SetActive(true);
    }

    public void previous6()
    {
        Panel6.SetActive(false);
        Panel5.SetActive(true);
    }

    public void next6()
    {
        Panel6.SetActive(false);
        Panel7.SetActive(true);
    }

    public void previous7()
    {
        Panel7.SetActive(false);
        Panel6.SetActive(true);
    }

    public void clue()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        CluePanel.SetActive(true);

    }

    public void story()
    {
        CluePanel.SetActive(false);
        Panel1.SetActive(true);
    }

    public void camera()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        CluePanel.SetActive(false);
        vars.task++;
        SceneManager.LoadScene("Task6");
    }
}
