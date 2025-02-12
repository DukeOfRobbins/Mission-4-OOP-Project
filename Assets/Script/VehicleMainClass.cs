using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehicleMainClass : MonoBehaviour
{
    public NavMeshAgent vehicle;

    public Transform currentVehicle;

    public Transform target;

    public void MoveTank()
        {
        vehicle.SetDestination(target.transform.position);
        }

    public void SelectVehicle()
        {
        RaycastHit vehicleHit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out vehicleHit, 1000))
            {
            if (Input.GetMouseButtonDown(0))
                {
                if (vehicleHit.transform.CompareTag("Tank"))
                    {
                    currentVehicle = vehicleHit.transform;
                    MoveTank();
                    }
                }
            }
        }

    private void Update()
        {
        //MoveTank();
        SelectVehicle();
        }
    }
