using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp2 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float hitPoints = 100f;
    public GameObject GunZ;
    public CapsuleCollider enemiesBox;

    public static float da1;
    public static bool ch;

    bool isDead = false;
    public bool IsDead()
    {
        return isDead;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ch)
        {
            //  da = da1;
            TakeDamage();

        }
    }

    public void TakeDamage()
    {
        // GetComponent<EnemyAi>().OnDamageTaken();
        //BroadcastMessage("OnDamageTaken");


        if (hitPoints > 0)
        {
            hitPoints -= da1;
        }
        Debug.Log(hitPoints);

       // hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Die();
            //Destroy(gameObject);
            GetComponent<Animator>().SetBool("dead", true);
            Debug.Log("isDead");

        }
    }
    private void Die()
    {
        if (isDead) return;
        isDead = true;

        //Destroy(gameObject);
        

        GunZ.active = false;

        enemiesBox.enabled = false;

    }
}
