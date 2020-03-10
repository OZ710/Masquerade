using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginSript : MonoBehaviour {

    public InputField uidField;
    public GameObject wrongLogin;
    void Start()
    {
        wrongLogin.SetActive(false);
    }


    IEnumerator getReq(string uid)
    {
        wrongLogin.SetActive(true);
        wrongLogin.GetComponent<UnityEngine.UI.Text>().text = "Please wait...";

        UnityWebRequest www = UnityWebRequest.Get("http://13.233.159.51:3000/app/team/" + uid);
        yield return www.SendWebRequest();
        

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            wrongLogin.GetComponent<UnityEngine.UI.Text>().text = www.error;
            wrongLogin.SetActive(true);
        }
        else
        {
            // Show results as text
            Debug.Log(www.downloadHandler.text);

            // Debug.Log(www.downloadHandler);


            Debug.Log(vars.teamData.name);
            Debug.Log(vars.teamData.level);
            // is alive
            if (www.downloadHandler.text == "failed")
            {
                wrongLogin.SetActive(true);
            }
            else
            {
                
                vars.teamData = JsonUtility.FromJson<Team>(www.downloadHandler.text); // converting retrieved data to object
                if (vars.teamData.isAlive)
                {
                    vars.task = vars.teamData.level;
                    if(vars.task == 7)
                    {
                        SceneManager.LoadScene("Showdown");
                    } 
                    else
                    {
                        SceneManager.LoadScene("Task" + vars.teamData.level);
                    }
                    Debug.Log(vars.teamData.isAlive);
                }
                else
                {
                    wrongLogin.SetActive(true);
                    wrongLogin.GetComponent<UnityEngine.UI.Text>().text = "You are DEAD!!!";
                }
                
            }


        }
    }


    public void getBtn()
    {
        vars.teamData.uid = uidField.text;
        StartCoroutine(getReq(uidField.text));
        Debug.Log("get-btn");
    }

   



    
}
