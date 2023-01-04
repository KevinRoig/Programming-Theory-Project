using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using EasyPrimitiveAnimals;

public class SheepController : AnimalController //INHERITANCE
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Jump();
        }
    }
    //POLYMORPHISM
    public override void Jump()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500f);
    }
}
