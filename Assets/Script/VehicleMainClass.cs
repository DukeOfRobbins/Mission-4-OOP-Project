using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehicleMainClass : MonoBehaviour
    {
    public NavMeshAgent vehicle;

    public Transform currentVehicle;

    public Transform currentTarget;

    public Transform target;

    public GameObject highlighter;

    public int speed;

    // ENCAPSULATION - Adding a Property to use for each Vehicle
    public int VehicleSpeed { get{return speed;} set{speed = value; } }

    private void Start()
        {
        speed = 0;
        highlighter.SetActive(false);
        }

    // OVERRIDING/POLYMORPHISM - Virtual method that can be overidden depending on vehicle selected
    public virtual void MoveTank()
        {
        currentTarget = target;
        vehicle.SetDestination(currentTarget.transform.position);
        }
    // ABSTRACTION - Providing methods to call potentially, in other scripts and provide functionality with one call

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
                    highlighter.SetActive(true);
                    }
                else
                    {
                    highlighter.SetActive(false);
                    }
                }
            }
        }

    // ABSTRACTION
    public void SelectDestination()
        {
        RaycastHit DestHit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out DestHit, 1000))
            {
            if (Input.GetMouseButtonDown(1))
                {
                if (DestHit.transform.CompareTag("SupplyDump"))
                    {
                    target = DestHit.transform;
                    MoveTank();
                    }
                }
            }
        }

    private void Update()
        {
        SelectVehicle();
        SelectDestination();
        }
    }
