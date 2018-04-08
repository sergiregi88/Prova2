using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initlevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        bl_SceneLoaderUtils.GetLoader.LoadLevel("MainMenu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
