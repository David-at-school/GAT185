using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceEnemy : MonoBehaviour, IDestructible
{
    [SerializeField] SpaceWeapon spaceWeapon;
    [SerializeField] GameObject[] pickups;
    [SerializeField] int dropChance;
    [SerializeField] float minFireTime;
    [SerializeField] float maxFireTime;

    public int points;
    private float timer;

    void Start()
    {
        timer = Random.Range(minFireTime, maxFireTime);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = Random.Range(minFireTime, maxFireTime);
            spaceWeapon?.Fire();
        }
    }

    public void Destroyed()
    {
        GameManager.Instance.Score += points;
        if (Random.Range(0, 100) > dropChance)
        {
            Instantiate(pickups[Random.Range(0,1)], gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
