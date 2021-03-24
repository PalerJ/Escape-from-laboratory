using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
     public Camera playerCamera;
    public Transform bulletP;
    public GameObject bulletPrefab;

    public GameObject[] loadout;

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    private void shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("shoot");
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = bulletP.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;

        }
    }
}
