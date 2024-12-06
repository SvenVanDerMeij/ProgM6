using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    // Start is called before the first frame update
    private float lives;
    public void StartRunnin(float race)
    {
        transform.position += new Vector3(race, 0, 0);
    }
    public void defineLives(float input)
    {
        lives = input;
    }

    public void hit(float damage)
    {
         lives -= damage;
        
        if (lives <= 0)
        {
            Destroy(gameObject);
        }
    }
}
