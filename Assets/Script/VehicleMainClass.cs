using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehicleMainClass : MonoBehaviour
{
    public NavMeshAgent vehicle;

    public Transform target;

    public void MoveTank()
        {
        vehicle.SetDestination(target.transform.position);
        }

    private void Update()
        {
        MoveTank();
        }
    }
