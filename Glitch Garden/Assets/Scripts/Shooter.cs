using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;

    private void Start() {

        SetLaneSpawner();
    }


    private void Update() {

        if(IsAttackerInLane()) {
            Debug.Log("shoot");
        }
        else {
            Debug.Log("sit and wait");
        }
    }

    private bool IsAttackerInLane() {

        if (myLaneSpawner.transform.childCount <= 0) {
            return false;
        }
        else {
            return true;
        }
    }

    private void SetLaneSpawner() {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners) {

            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);

            if(IsCloseEnough) {
                myLaneSpawner = spawner;
            }
        }
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }
}
