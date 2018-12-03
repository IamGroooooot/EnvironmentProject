using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jCreateDust : MonoBehaviour {
    public float delay = 10f;
    public GameObject dust;
    public Transform RandomPos;
    public Rigidbody PlayerRB;
    float Counter = 0;
    bool NewPos = true;
	// Use this for initialization
	void Start () {
        StartCoroutine(makeDust());
	}
	
	// Update is called once per frame
	void Update () {
        if (NewPos)
        {
            RandomPos.position = new Vector3(PlayerRB.position.x + Random.Range(-10f, 10f), PlayerRB.position.y + Random.Range(10f, 100f), PlayerRB.position.z + Random.Range(-10f, 10f));
            NewPos = false;
        }
        Counter = Counter + Time.deltaTime;
        if (Counter>1f) {
            GameObject temp = Instantiate(dust, RandomPos, false);
            temp.transform.SetParent(transform.parent);
            temp.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Counter = 0;
            NewPos = true;
        }
    }

    IEnumerator makeDust()
    {
        
        yield return new WaitForSeconds(3f);
    }
}

