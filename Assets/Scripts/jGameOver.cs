using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class jGameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onBtn0Clicked()
    {
        SceneManager.LoadScene(1);
    }

    public void onBtnClicked()
    {
        SceneManager.LoadScene(1);
    }
    public void onBtn2Clicked()
    {
        SceneManager.LoadScene(2);
    }
}
