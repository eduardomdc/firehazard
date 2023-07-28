using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Extintor : MonoBehaviour
{
    public ParticleSystem gasExtintor;
    //Emission controla o quanto de particulas sai do extintor
    public ParticleSystem.EmissionModule emission;
    
    void Start()
    {
        emission = gasExtintor.emission;
        emission.rateOverTime = 0;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {   
            emission.rateOverTime = 630;
        }
         if(Input.GetMouseButtonUp(0))
        {
            emission.rateOverTime = 0;
        }

    }
}






