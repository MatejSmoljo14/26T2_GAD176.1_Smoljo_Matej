using UnityEngine;
using SAE.GAD176.Scripting2.Project1.CharacterBondSystem;
using UnityEngine.InputSystem;
public class Rocco : CharacterStats
{
    // All the characters who the first character can bond with
    public float bondWithRoccoAndEvee = 0f;

    private float bondWithRoccoAndMartin = 0f;

    private float bondWithRoccoAndCharlie = 0f;

    void Start()
    {
        // Set the name on play
        characterName = "Rocco";
        characterBondTableID = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Inputs to test 
        if (Input.GetKeyDown(KeyCode.Q))
        {
            BondIncrease();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            
        }
    }

    void BondIncrease()
    {
        bondWithRoccoAndEvee += .5f;
        bondWithRoccoAndMartin += 1f;
        bondWithRoccoAndCharlie += 1.5f;
    }
}
