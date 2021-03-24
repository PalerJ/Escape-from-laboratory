using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] float rangeGizmos, turnSpeed,damageEnemyAI;

    [SerializeField] Transform target;
    [SerializeField] float chaseRage = 5f;
    NavMeshAgent navMeshAgent;
    float distanceTotarget = Mathf.Infinity;

    public ParticleSystem FireParticle;

    

    //week3
    private bool isProvoked = false;//ให้ศัตรูรู้ว่า player เข้ามาในเขต

    EnemyHp2 healthh;
    

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        healthh = GetComponent<EnemyHp2>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceTotarget = Vector3.Distance(target.position, transform.position);

        if (distanceTotarget <= chaseRage)
        {
            isProvoked = true;
        }
        if (isProvoked == true)
        {
            EngageTarget();
        }

        if (healthh.IsDead())
        {
            enabled = false;
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRage);
    }
    private void EngageTarget()
    {
        FaceTarget();

        if (distanceTotarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }
        else if (distanceTotarget < navMeshAgent.stoppingDistance)
        {
            
            AttackTarget();

        }
    }

    // run to player
    private void ChaseTarget()
    {
        GetComponent<Animator>().SetBool("move", true);
        //GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);

    }

    // atk
    private void AttackTarget()
    {
        
        GetComponent<Animator>().SetBool("move", false);
        RaycastProcess();

        FireParticle.Emit(1);
        // GetComponent<Animator>().SetBool("attack", true);
        Debug.Log("Attack");
    }

    // หมุนตาม
    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotatetion = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        //transform.rotation = lookRotatetion;
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotatetion, Time.deltaTime * turnSpeed);
    }

    //raycast chk
    private void RaycastProcess()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 8))
        {
            PlayerHealth target = hit.transform.GetComponent<PlayerHealth>();
            if (target == null)
            {
                return;
            }
            target.HealthPlayer(damageEnemyAI);


        }
    }

    public void OnDamageTaken()
    {
        isProvoked = true;

    }
}
