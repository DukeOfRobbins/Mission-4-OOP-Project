using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TankNavigation : MonoBehaviour
{
    public NavMeshAgent tank;

    public GameObject target;

    public void MoveTank()
        {
        tank.SetDestination(target.transform.position);
        }

    private void Update()
        {
        MoveTank();
        }
    }
