using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResgateAmbulancia : MonoBehaviour
{
    public GameObject torso;
    public Collider2D ambulanciaArea;
    public Sprite torsoPadrao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
 public void OnTruckTriggerStay(Collider other)
    {
        Debug.Log("Colidindo com caminhão");
        if (Input.GetKeyDown("e"))
        {
            torso.GetComponent<SpriteRenderer>().sprite = torsoPadrao;
            this.gameObject.GetComponent<PlayerPerna>().speed = 3.4f;
            print("EITAPORRAAA");
        }
    }
}
