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
    void Start()
    {
        //var particleSystem = gameObject.GetComponent<ParticleSystem>();
        //var emissionModule = particleSystem.emission;
        
        gasExtintor.emissionRate = 0;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {   
            
            gasExtintor.emissionRate = 160;
        }
         if(Input.GetMouseButtonUp(0))
        {
        //var particleSystem = gameObject.GetComponent<ParticleSystem>();
        //var emissionModule = particleSystem.emission;
            gasExtintor.emissionRate = 0;
        }

    }
}






