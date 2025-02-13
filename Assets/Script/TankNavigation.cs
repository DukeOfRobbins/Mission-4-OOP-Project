using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TankNavigation : VehicleMainClass
{
    // Override MoveTank with Vehicle Speed
    // Use encapsulated Speed Property
    public override void MoveTank()
        {
        VehicleSpeed = 5;
        vehicle.speed = VehicleSpeed;
        base.MoveTank();
        }
    }
