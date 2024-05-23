using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 50f;
    public int score = 20;

    public void GetDamage( float damage )
    {
        health -= damage;           
        if (health <= 0)
        {
            GameManager.instance.UpdateScore(score);
            Destroy(this.gameObject);
        }
    }
}
