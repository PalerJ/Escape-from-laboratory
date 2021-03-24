using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour
{
    public GameObject gate;
    public GameObject gate2;
    public GameObject gate3;
    public GameObject gate4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&& gate)
        {
            SceneManager.LoadScene(2);
        }
        else if (other.gameObject.tag == "Player" && gate2)
        {
            SceneManager.LoadScene(3);
        }
        else if (other.gameObject.tag == "Player" && gate3)
        {
            SceneManager.LoadScene(4);
        }
        else if (other.gameObject.tag == "Player" && gate4)
        {
            SceneManager.LoadScene(5);
        }

    }
}
