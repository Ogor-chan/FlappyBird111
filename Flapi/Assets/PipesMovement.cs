using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        ////eqasad
        ///

        if(transform.position.x == -13)
        {
            Destroy(this.gameObject);
        }
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
