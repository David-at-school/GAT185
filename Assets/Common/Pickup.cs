using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("DamagePickup"))
        {
            other.gameObject.GetComponent<Damage>().damage += 5;
        }
        if (gameObject.CompareTag("FireRatePickup"))
        {
            other.gameObject.GetComponent<SpaceWeapon>().fireRate *= 0.8f;
        }
        Destroy(gameObject);
    }
}