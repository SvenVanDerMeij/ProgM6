using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IMovable, IDamagable
{
    // Start is called before the first frame update
    private int health;
    public int Health { get { return health; } }

    public virtual void Move(float race)
    {
        transform.position += new Vector3(race, 0, 0);
    }

    public void defineLives(int input)
    {
        health = input;
    }
   
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
     
}
