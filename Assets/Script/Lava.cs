using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    public GameObject lava1;
    public GameObject lava2;
    public GameObject lava3;
    public GameObject lava4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&&lava1)
        {
            
            SceneManager.LoadScene(1);
        }
        else if (other.gameObject.tag == "Player" && lava2)
        {

            SceneManager.LoadScene(2);
        }
        else if (other.gameObject.tag == "Player" && lava3)
        {

            SceneManager.LoadScene(3);
        }
        else if (other.gameObject.tag == "Player" && lava4)
        {

            SceneManager.LoadScene(4);
        }
    }
}
