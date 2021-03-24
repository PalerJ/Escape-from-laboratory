using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour
{
    public GameObject myWeapon;
    public Canvas dot;
    void Start()
    {
        myWeapon.SetActive(false);
        dot.enabled = false;
    }

    private void OnTriggerEnter(Collider _collider)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (_collider.gameObject.tag == "Player")
            {
                myWeapon.SetActive(true);
                Destroy(gameObject);
                dot.enabled = true;
            }
        }
        
        
    }

}
