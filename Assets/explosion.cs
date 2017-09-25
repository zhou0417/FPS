using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {
    public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameObject explosion = (GameObject)Instantiate(explosionPrefab,
            transform.position,
            transform.rotation);
        Destroy(explosion, 3.0f);
    }
}
