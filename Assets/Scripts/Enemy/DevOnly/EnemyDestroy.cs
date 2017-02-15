using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {

    private Health hp;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ExitWall"))
        {
            Destroy(this.gameObject);
        }
    }
}
