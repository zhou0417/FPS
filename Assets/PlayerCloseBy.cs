using UnityEngine;
using System.Collections;

public class PlayerCloseBy : MonoBehaviour
{
    public GetKey playerGetKey;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) < 0.3f)
        {
            playerGetKey.KeyGot();
        }
    }
}
