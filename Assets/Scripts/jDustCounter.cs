using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jDustCounter : MonoBehaviour {
    public static jDustCounter instance = null;        // for singleton
    public static int totalDust = 0;
    public static int MAX_dust=3000;  //나중에 get ㄱㄱ
    //여기서 농도 설정 
    public int myPPM=0;

    //맵 크기
    public float mapSize;

    //myPPM이용해서 toatalDust역산해서 MAX_dust 설정하고 외부에서 접근 못하도록 하기

    // Use this for initialization
    void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
