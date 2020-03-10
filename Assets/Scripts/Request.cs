using UnityEngine.Networking;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class Request : MonoBehaviour{

   
    public IEnumerator postReq()
    {
        vars.teamData.level = vars.task + 1 ;
        Debug.Log(vars.teamData.level+"");
        WWWForm formData = new WWWForm();
        formData.AddField("level", vars.teamData.level);

        UnityWebRequest www = UnityWebRequest.Post("http://13.233.159.51:3000/app/team/" + vars.teamData.uid + "/update", formData);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
        }
    }


}

