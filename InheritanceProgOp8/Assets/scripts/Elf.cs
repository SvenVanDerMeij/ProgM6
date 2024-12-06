using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Unit, IMovable, IDamagable
{
    private float invisibletimer;
    
    // Start is called before the first frame update
    void Start()
    {
        defineLives(2);
        
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(invisibletimer);
        invisibletimer += 1 * Time.deltaTime;
        if (invisibletimer < 3) 
        {
            ToggleInvisibility(true);
        } else if (invisibletimer > 3)
        {
            ToggleInvisibility(false);
        }
        if (invisibletimer > 6)
        {
            invisibletimer = 0;
            
        }
        Move(4 * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        TakeDamage(1);
        
    }
    private void ToggleInvisibility(bool visible)
    {
        gameObject.GetComponent<Renderer>().enabled = visible;
    }
}

