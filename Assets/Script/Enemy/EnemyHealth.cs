using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float Hppoint = 100f;
    bool isDead = false;
    public GameObject Gunz;
    public CapsuleCollider enemiesBox;

    public bool IsDead()
    {
        return isDead;
    }
    public void TakeDamage(float damage)
    {
        //BroadcastMessage("OnDamageTaken");

        Hppoint -= damage;
        if (Hppoint <= 0)
        {
            Die();
            GetComponent<Animator>().SetTrigger("dead");
            //Destroy(gameObject);
        }
    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        Debug.Log("IsDead");
        
        Gunz.active = false;
        enemiesBox.enabled = false;
    }




}
