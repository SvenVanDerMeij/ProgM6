using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit, IMovable, IDamagable
{
    // Start is called before the first frame update
    float moveSpeed = 5;
    float rotationSpeed = 95;
    void Start()
    {
        defineLives(5);
    }

    // Update is called once per frame
    void Update()
    {
        Move(6f);
    }
    public override void Move(float _)
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
    private void OnCollisionEnter(Collision collision)
    {
        TakeDamage(1);

    }
}
