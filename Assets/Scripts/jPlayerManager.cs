using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class jPlayerManager : MonoBehaviour {
    public GameObject mPlayer;
    public Rigidbody mRigidBD;
    public Image im;

    void Awake()
    {
        
    }

	// Use this for initialization
	void Start () {
        mPlayer = gameObject.GetComponent<GameObject>();
        mRigidBD = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (jDustCounter.instance.totalDust > 0)
        {
            float myAlpha = 0;
            myAlpha = jDustCounter.instance.totalDust*3.5f / jDustCounter.instance.MAX_dust;
            if (myAlpha>2.5f)
            {
                myAlpha = 2.5f;
            }
            im.GetComponent<CanvasRenderer>().SetAlpha(myAlpha);
        }
        mRigidBD.velocity = new Vector3(0,0,0);
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
        {
            mRigidBD.velocity = new Vector3(0,0,-10);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            mRigidBD.velocity = new Vector3(0, 0, 10);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            mRigidBD.velocity = new Vector3(10, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            mRigidBD.velocity = new Vector3(-10, 0, 0);
        }
    }
}
