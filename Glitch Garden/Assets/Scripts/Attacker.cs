using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)] float currnetSpeed = 1f;
    GameObject currentTarget;
    
    void Update()
    {
        transform.Translate(Vector2.left * currnetSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    private void UpdateAnimationState() {
        if(!currentTarget) {
            GetComponent<Animator>().SetBool("IsAttacking", false);
        }
    }

    public void SetMovementSpeed(float speed)
    {
        currnetSpeed = speed;
    }

    public void Attack(GameObject target) {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage) {
        if(!currentTarget) { return; }

        Health health = currentTarget.GetComponent<Health>();

        if(health) {
            health.DealDamage(damage);
        }
    }
}
