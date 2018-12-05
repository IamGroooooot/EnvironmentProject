using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jSpawner : MonoBehaviour {
    Vector3 SpawnPos;
    public GameObject myCar;
    float counter = 0;
	// Use this for initialization
	void Start () {
        SpawnPos.y = myCar.transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        
        counter += Time.deltaTime;
        if (counter > 3f)
        {
            SpawnPos.x = Random.Range(-10,10);
            SpawnPos.z = Random.Range(-5, 0);
            GameObject TempCar = Instantiate(myCar,SpawnPos,myCar.transform.rotation);
            counter = 0f;
            Debug.Log("My Car Spawn");
        }
    }

    
}
