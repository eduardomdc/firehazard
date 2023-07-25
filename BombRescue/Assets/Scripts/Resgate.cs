using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Resgate : MonoBehaviour
{
    public GameObject torso;
    public GameObject pessoa, pessoaResgatada1;
    public Sprite resgatandoPessoa, torsoPadrao;
    public GameObject ambulancia;
    private bool pegaPessoa, devolvePessoaResgatada1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown("e") && pegaPessoa == true)
        {
            torso.GetComponent<SpriteRenderer>().sprite = resgatandoPessoa;
            this.gameObject.GetComponent<PlayerPerna>().speed = 1.5f;
            pessoa.SetActive(false);
            print("Resgate");
        }
        if(Input.GetKeyDown("e") && devolvePessoaResgatada1 == true)
        {
            torso.GetComponent<SpriteRenderer>().sprite = torsoPadrao;
            this.gameObject.GetComponent<PlayerPerna>().speed = 3.4f;
            print("EITAPORRAAA");
            pessoaResgatada1.SetActive(true);
        }    
    }

    public void OnTriggerStay2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("pessoaFerida"))
        {
            pegaPessoa = true;
        }

        if (other.gameObject.CompareTag("ambulancia"))
        {
            devolvePessoaResgatada1 = true;
            pegaPessoa = false;
        }
    
    }
    
}
