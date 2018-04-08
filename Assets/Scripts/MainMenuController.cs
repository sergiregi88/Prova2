using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour {

    [Header("Options Panel")]
    public GameObject mainOptionsPanel;
    public GameObject startGameOptionsPanel;
    public GameObject reconfigPanel;
    public GameObject gamePanel;
    public GameObject controlsPanel;
    public GameObject gfxPanel;
    public GameObject Fader;

    [HideInInspector]
    private Fader FaderScript;
    //public GameObject loadGamePanel;
    // Use this for initialization
    void Start () {
        FaderScript = Fader.GetComponent<Fader>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CloseStartGameOptions()
    {
        mainOptionsPanel.SetActive(true);
        startGameOptionsPanel.SetActive(false);
        reconfigPanel.SetActive(false);
    }
    public void OpenStartGameOptions()
    {
        mainOptionsPanel.SetActive(false);
        startGameOptionsPanel.SetActive(true);
        reconfigPanel.SetActive(false);
    }
    public void NewGame()
    {
        FaderScript.FadeIntoLevel("Level1");
     

    }
}
