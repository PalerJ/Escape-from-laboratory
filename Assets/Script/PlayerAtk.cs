using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtk : MonoBehaviour
{
    [SerializeField] Camera FPCamere;
    [SerializeField] float range = 100;
    [SerializeField] float damage = 30;
    bool canShoot = true;
    [SerializeField] float timeBetweenShot = 0.2f;
    private void OnEnable()
    {
        canShoot = true;
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && canShoot == true)
        {
            SoundManager.playSound("shoot2");
            StartCoroutine(Shoot());
        }
    }
    IEnumerator Shoot()
    {
        canShoot = false;
        RaycastProcess();
        yield return new WaitForSeconds(timeBetweenShot);
        canShoot = true;
    }



    private void RaycastProcess()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamere.transform.position, FPCamere.transform.forward, out hit, range))
        {
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();

            //Debug.Log("I hit this thing :" + hit.transform.name);
            if (target == null)
            {
                return;
            }
            Debug.Log(damage);
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }
    }
}
