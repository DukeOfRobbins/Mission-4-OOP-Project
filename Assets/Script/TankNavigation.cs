using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TankNavigation : VehicleMainClass
{
    // INHERITANCE - bringing all required functionality to this script from VehicleMainClass
    // Override MoveTank with Vehicle Speed
    // Use encapsulated Speed Property
    // OVERRIDING/POLYMORPHISM - Overriding MoveTank Function depending on type of Vehicle with Vehicle Speed
    public override void MoveTank()
        {
        VehicleSpeed = 5;
        vehicle.speed = VehicleSpeed;
        base.MoveTank();
        }
    }
