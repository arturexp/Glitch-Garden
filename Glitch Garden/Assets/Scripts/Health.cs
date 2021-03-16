using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TrigerDeathVFX();
            Destroy(gameObject);
        }
    }

    public void TrigerDeathVFX()
    {
        if (!deathVFX) { return; }
        GameObject deathVFXobject = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(deathVFXobject, 2f);
    }
}
