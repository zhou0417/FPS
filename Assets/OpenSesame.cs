using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenSesame : MonoBehaviour
{
    public GameObject player;
    public bool opening = false;
    // Use this for initialization
    void Start()
    {

    }

    public void moveDown()
    {
        opening = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (opening)
        {
            transform.Translate(0, -Time.deltaTime / 2, 0);
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("scene3", LoadSceneMode.Single);
    }
}
