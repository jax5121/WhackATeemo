using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour
{
    public static bool regenActive;
    private Button regenButton;

    public void ActivateRegen()
    {
        regenActive = true;
    }

    void Start()
    {
        regenButton = GameObject.Find("btnAbility2").GetComponent<Button>();
    }

    void Update()
    {
        //regenButton.interactable = regenActive;
    }
}
