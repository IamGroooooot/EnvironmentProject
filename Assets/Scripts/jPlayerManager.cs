using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jPlayerManager : MonoBehaviour {
    public GameObject mPlayer;
    public Rigidbody mRigidBD;

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
        mRigidBD.velocity = new Vector3(0,0,0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            mRigidBD.velocity = new Vector3(0,0,-20);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mRigidBD.velocity = new Vector3(0, 0, 20);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            mRigidBD.velocity = new Vector3(20, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            mRigidBD.velocity = new Vector3(-20, 0, 0);
        }
        Debug.Log(mPlayer.ToString());
    }
}
