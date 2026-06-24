using UnityEngine;
using SAE.GAD176.Scripting2.Project1.CharacterBondSystem;
using System.Collections.Generic;
using Unity.Android.Gradle;
using Unity.Android.Gradle.Manifest;
using System.Collections.ObjectModel;
public class BondTable : MonoBehaviour
{
    // How can this script see all the bond variables?????

    // Character Name
    // Bond level with ...
    


    [SerializeField]
    protected GameObject Rocco;

    [SerializeField]
    protected GameObject Evee;

    [SerializeField]
    protected GameObject Martin;

    private Rocco roccoScript;
    private Evee eveeScript;
    private Martin martinScript;

    [SerializeField]
    //private float RoccoBondTest = roccoScript.bondWithRoccoAndEvee;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
