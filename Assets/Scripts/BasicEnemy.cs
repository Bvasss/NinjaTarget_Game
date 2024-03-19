using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicEnemy : MonoBehaviour
{
    [Header("Stats")]
    public int health;
    public int puntaje;



    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0){
            Destroy(gameObject);
    }
}}
