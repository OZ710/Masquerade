using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Task4 : MonoBehaviour {

    public GameObject Panel1, Panel2, Panel3, CluePanel;
    void Start()
    {
        Panel2.SetActive(false);
        Panel3.SetActive(false);
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

   

    public void clue()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
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
        CluePanel.SetActive(false);
        vars.task++;
        SceneManager.LoadScene("Task5");
    }
}
