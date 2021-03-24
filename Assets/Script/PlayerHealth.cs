using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    
    [SerializeField] float health;

    private void Start()
    {
        //
    }
    public void HealthPlayer(float damageEnemy)
    {
        health -= damageEnemy;
        if (health <= 0)
        {
            Debug.Log("Dead");

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
    }
}
