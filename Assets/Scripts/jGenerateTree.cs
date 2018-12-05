﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jGenerateTree : MonoBehaviour {
    public GameObject myTree;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            GameObject tempTree=Instantiate(myTree,transform,false);
            tempTree.transform.SetParent(transform.parent);
            Destroy(tempTree,3f);
            
            if (jDustCounter.totalDust>9)
            {
                jDustCounter.totalDust -= 10;
            }
            else
            {
                jDustCounter.totalDust = 0;
            }
        }
    }
}
