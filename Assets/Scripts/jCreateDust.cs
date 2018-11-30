using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jCreateDust : MonoBehaviour {
    public float delay = 10f;
    public GameObject[] dust;

	// Use this for initialization
	void Start () {
        StartCoroutine(makeDust());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator makeDust()
    {

        yield return new WaitForSeconds(10f);
    }
}

