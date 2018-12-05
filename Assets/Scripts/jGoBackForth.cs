using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jGoBackForth : MonoBehaviour {
    Rigidbody myCarRigid;
    float counter = 0;
	// Use this for initialization
	void Start () {
        myCarRigid = gameObject.GetComponent<Rigidbody>();
        Destroy(this.gameObject,10f);
    }
	
	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime;
        myCarRigid.velocity = new Vector3(0,0,3);
        if (counter>0.5f)
        {
            jDustCounter.instance.totalDust += 100;
            counter = 0;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tree")
        {
            Destroy(this.gameObject);
        }
    }
}
