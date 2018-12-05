using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jChangeA : MonoBehaviour {
    public Image im;
    float myValue=0;
    bool isInc = true;
    // Use this for initialization
    void Start () {
        im.GetComponent<CanvasRenderer>().SetAlpha(0);

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (myValue < 2.5f&&isInc) { 

            myValue += Time.deltaTime;
            im.GetComponent<CanvasRenderer>().SetAlpha(myValue);
        }
        else
        {
            myValue -= Time.deltaTime;
            im.GetComponent<CanvasRenderer>().SetAlpha(myValue);
            isInc = false;
        }
        if(isInc==false && myValue < 0)
        {
            isInc = true;
        }
    }
}
