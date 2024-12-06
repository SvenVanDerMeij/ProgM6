using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : Unit, IMovable, IDamagable
{
    
    // Start is called before the first frame update
    void Start()
    {
        defineLives(4);
    }

    // Update is called once per frame
    void Update()
    {
        Move(3*Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        TakeDamage(1);
       
    }
}
