using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float damage = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Health>(out Health otherHealth))
        {
            otherHealth.Damage(damage);
        }
        /*if (gameObject.TryGetComponent<Health>(out Health health) && other.gameObject.TryGetComponent<Damage>(out Damage otherDamage))
        {
            health.Damage(otherDamage.damage);
        }*/
    }
}
