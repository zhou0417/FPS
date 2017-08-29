using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
    public GameObject bulletSpawn;
    public GameObject bullet;
    float countdown = -1;
	// Use this for initialization
	void Start () {
        bulletSpawn = GameObject.FindWithTag("GameObject");
	}
	
	// Update is called once per frame
	void Update () {
        countdown = countdown - Time.deltaTime;
        if (countdown < 0)
        {
            countdown = 0.5f;
            GameObject obj = (GameObject)Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            obj.GetComponent<Rigidbody>().velocity = Vector3.back * 20;
            Destroy(obj, 5.0f);
        }
	}
}
