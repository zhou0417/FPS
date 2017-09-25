using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int playersLife = 100;
    public AudioClip painClip, lifeClip;
    public Text txt;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "" + playersLife;


    }
    public void TakeDamage()
    {
        GetComponent<AudioSource>().PlayOneShot(painClip);
        playersLife = playersLife - 10;
        if (playersLife <= 0)
        {

            SceneManager.LoadScene("scene2", LoadSceneMode.Single);
        }

    }
    public void TakeLife()
    {
        GetComponent<AudioSource>().PlayOneShot(lifeClip);
        playersLife = playersLife + 10;
    }
}
