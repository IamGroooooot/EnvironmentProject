using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//.instance
public class jDustCounter : MonoBehaviour {
    public static jDustCounter instance = null;        // for singleton
    public int totalDust = 0;
    public int MAX_dust=3000;  //나중에 get ㄱㄱ
    public float delay = 0.1f;
    public Text mVal;
    //여기서 농도 설정 
    public int myPM=0;
    //맵 크기
    public float mapSize;

    //myPPM이용해서 toatalDust역산해서 MAX_dust 설정하고 외부에서 접근 못하도록 하기

    // Use this for initialization
    void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
        myPM = 600 * totalDust / MAX_dust;
        
        mVal.text = Mathf.Floor(myPM).ToString();
        if (Mathf.Floor(myPM)>400)
        {
            SceneManager.LoadScene(2);
        }
	}
}
