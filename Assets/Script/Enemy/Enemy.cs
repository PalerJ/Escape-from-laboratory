using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] float rangeGizmos, turnSpeed, damageEnemyAI;
    [SerializeField] Transform target;
    NavMeshAgent navMeshAgent;
    private float distace;
    private bool checkmove = false;
    private bool move = false;
    public ParticleSystem FireParticle;

    EnemyHealth health;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        health = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        distace = Vector3.Distance(target.position, transform.position);
        if (distace < rangeGizmos)
        {
            ///เช็คตำแหน่ง
            checkmove = true;
        }
        if (checkmove == true)
        {
            //Debug.Log("Checkmove True");
            ///หมุน เดิน และโจมตี
            Vector3 direction = (target.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
            //เดิน
            if (distace >= navMeshAgent.stoppingDistance)
            {
                ///แอนิเมชั่นเดิน
                ChaseTarget();
                //navMeshAgent.SetDestination(target.position);

            }
            //และโจมตี
            if (distace < navMeshAgent.stoppingDistance)
            {
                GetComponent<Animator>().SetBool("move", false);
                //player.GetComponent<PlayerHealth>().HealthPlayer(damageEnemyAI);
                RaycastProcess();

                FireParticle.Emit(1);
                ///แอนิเมชั่นตี
            }
        }
        // ถ้าenemyตายหยุดทำงาน
        if (health.IsDead())
        {
            enabled = false;
        }
    }
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

    private void ChaseTarget()
    {
        GetComponent<Animator>().SetBool("move", true);
        //GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, rangeGizmos);
    }



}
