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

    private ParticleSystem.EmissionModule emission;
    
    void Start()
    {
        emission = gasExtintor.emission;
        emission.rateOverTime = 0;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {   
            emission.rateOverTime = 160;
        }
         if(Input.GetMouseButtonUp(0))
        {
            emission.rateOverTime = 0;
        }

    }
}






