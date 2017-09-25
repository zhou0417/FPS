using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
    public AudioClip shootSound;
    public GameObject bulletPrefab;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
           GetComponent<AudioSource>().PlayOneShot(shootSound);
       
            GameObject b = (GameObject)Instantiate(
                bulletPrefab,
                transform.position,
                transform.rotation);
            b.GetComponent<Rigidbody>().velocity = transform.forward * 15;
            

        }
    }
}
