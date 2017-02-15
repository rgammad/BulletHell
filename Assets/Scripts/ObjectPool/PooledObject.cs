using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObject : MonoBehaviour
{

    public float aliveTime = 0.5f;

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Wall"))
            Destroy();

        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy();
        }


    }

    void Destroy()
    {
        gameObject.SetActive(false);
    }

    void OnDisable()
    {
        CancelInvoke();
    }
}
