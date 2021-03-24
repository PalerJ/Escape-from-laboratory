using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedBullet;

    public float range = 10f;

    public float force = 700f;
    public float redius = 5f;
    private float timeremovebullet;
    public float damageBullet = 50;
    [SerializeField] GameObject enemy;

    Enemy enemyz;
    EnemyHealth enemyzz;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timeremovebullet += Time.deltaTime;
        transform.position += transform.forward * speedBullet * Time.deltaTime;
        //Debug.Log(timeremovebullet);
        if (timeremovebullet > 5)
        {
            Destroy(gameObject);
        }

    }
   /* private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Enemy")
        {
            enemyz = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy2")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy2").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy2").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy3")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy3").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy3").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy4")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy4").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy4").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy5")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy5").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy5").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy6")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy6").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy6").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy7")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy7").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy7").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy8")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy8").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy8").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy9")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy9").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy9").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy10")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy10").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy10").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy11")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy11").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy11").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy12")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy12").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy12").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy13")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy13").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy13").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy14")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy14").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy14").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy15")
        {
            enemyz = GameObject.FindGameObjectWithTag("enemy15").GetComponent<Enemy>();
            enemyzz = GameObject.FindGameObjectWithTag("enemy15").GetComponent<EnemyHealth>();
            enemyzz.da1 = damageBullet;
            enemyzz.ch = true;


            //Destroy(enemyz.gameObject);

            Destroy(gameObject);
        }

    }*/

   
}
