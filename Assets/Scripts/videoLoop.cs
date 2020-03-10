using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videoLoop : MonoBehaviour {
	public UnityEngine.Video.VideoPlayer videoPlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!videoPlayer.isPlaying)
			videoPlayer.Play();
	}
}
