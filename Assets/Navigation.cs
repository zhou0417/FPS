using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    public Transform playerTransform;
    public float dist;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent nm = GetComponent<NavMeshAgent>();
        dist = Vector3.Distance(playerTransform.position, gameObject.transform.position);
        if (dist > 0)
        {
            
            nm.Resume();
            nm.SetDestination(playerTransform.position);
        }
        else
        {
            
            nm.Stop();
        }
    }
}

