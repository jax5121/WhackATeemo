using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public static bool regenPower;

    public void ActivateRegen()
    {
        regenPower = true;
    }
}
