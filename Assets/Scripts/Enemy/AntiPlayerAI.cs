using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiPlayerAI : MonoBehaviour {

    public GameObject bulletPrefab;

    public float phase1FireStart = 10.0f;
    private float phase1StartTime = 5.0f;
    public int phase1MaxBulletCount = 3;
    public int phase1BulletCount = 3;


    private Vector3 offset;
    private int phase = 0;
    private List<Transform> bulletSpawnPos;
    void Start()
    {
        float height = gameObject.GetComponentInChildren<SpriteRenderer>().bounds.size.y;
        offset = new Vector3(0, (height / 2) + .15f);
        bulletSpawnPos = new List<Transform>();
        bulletSpawnPos.Add(transform.FindChild("BulletSpawnHolder").transform.FindChild("BulletSpawnMiddle"));
        bulletSpawnPos.Add(transform.FindChild("BulletSpawnHolder").transform.FindChild("BulletSpawnLeft"));
        bulletSpawnPos.Add(transform.FindChild("BulletSpawnHolder").transform.FindChild("BulletSpawnRight"));
        
    }

    
    void Update () {
        if (phase == 0)
        {
            _PhaseOne();
        }
	}

    void _PhaseOne()
    {
        if (Time.time > phase1StartTime)
        {
            phase1StartTime = Time.time + phase1FireStart;
            if (phase1BulletCount > 0)
            {
                foreach (Transform spawn in bulletSpawnPos)
                {
                    BetterPool.Spawn(bulletPrefab, spawn.position);
                }
                phase1BulletCount--;
            }
            else
                phase1BulletCount = phase1MaxBulletCount;
        }
    }
}
