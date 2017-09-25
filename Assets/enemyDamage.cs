using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class enemyDamage : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        disappear p = other.GetComponent<disappear>();
        if (p != null) p.TakeDamage();
        Destroy(gameObject);
    }
}
