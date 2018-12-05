using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jCreateDust : MonoBehaviour {
    public GameObject dust;
    public Transform RandomPos;
    public Rigidbody PlayerRB;
    float Counter = 0;
    bool NewPos = true;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (NewPos)
        {
            RandomPos.position = new Vector3(PlayerRB.position.x + Random.Range(-10f, 10f), PlayerRB.position.y + Random.Range(10f, 100f), PlayerRB.position.z + Random.Range(-10f, 10f));
            NewPos = false;
        }
        Counter = Counter + Time.deltaTime;
        if (Counter> jDustCounter.instance.delay &&jDustCounter.instance.totalDust<jDustCounter.instance.MAX_dust) {
            GameObject temp = Instantiate(dust, RandomPos, false);
            if (temp != null)
            {
                temp.transform.SetParent(transform.parent);
                temp.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            RandomPos.position = new Vector3(PlayerRB.position.x + Random.Range(-10f, 10f), PlayerRB.position.y + Random.Range(10f, 100f), PlayerRB.position.z + Random.Range(-10f, 10f));
            GameObject temp2 = Instantiate(dust, RandomPos, false);
            if (temp2 != null)
            {
                temp2.transform.SetParent(transform.parent);
                temp2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            RandomPos.position = new Vector3(PlayerRB.position.x + Random.Range(-10f, 10f), PlayerRB.position.y + Random.Range(10f, 100f), PlayerRB.position.z + Random.Range(-10f, 10f));
            GameObject temp3 = Instantiate(dust, RandomPos, false);
            if (temp3 != null)
            {
                temp3.transform.SetParent(transform.parent);
                temp3.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            RandomPos.position = new Vector3(PlayerRB.position.x + Random.Range(-10f, 10f), PlayerRB.position.y + Random.Range(10f, 100f), PlayerRB.position.z + Random.Range(-10f, 10f));
            GameObject temp4 = Instantiate(dust, RandomPos, false);
            if (temp4 != null)
            {
                temp4.transform.SetParent(transform.parent);
                temp4.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            RandomPos.position = new Vector3(PlayerRB.position.x + Random.Range(-10f, 10f), PlayerRB.position.y + Random.Range(10f, 100f), PlayerRB.position.z + Random.Range(-10f, 10f));
            GameObject temp5 = Instantiate(dust, RandomPos, false);
            if (temp5 != null)
            {
                temp5.transform.SetParent(transform.parent);
                temp5.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            Counter = 0;
            NewPos = true;
            jDustCounter.instance.totalDust = jDustCounter.instance.totalDust+5;
        }
    }
}

