using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : EnemyParent
{
    
    // Start is called before the first frame update
    void Start()
    {
        defineLives(4);
    }

    // Update is called once per frame
    void Update()
    {
        StartRunnin(3*Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        hit(1);
       
    }
}
