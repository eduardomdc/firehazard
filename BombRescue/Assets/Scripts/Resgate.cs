using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Resgate : MonoBehaviour
{
    public GameObject torso;
    public GameObject pessoa1, pessoaResgatada1;
    public Sprite SpriteResgatandoPessoa1, torsoPadrao;
    public GameObject ambulancia;
    private bool pegaPessoa1, devolvePessoaResgatada1, resgatandoPessoa1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log(pegaPessoa1);
        if(Input.GetKeyDown("e") && pegaPessoa1 == true)
        {
            resgatandoPessoa1 = true;
            torso.GetComponent<SpriteRenderer>().sprite = SpriteResgatandoPessoa1;
            this.gameObject.GetComponent<PlayerPerna>().speed = 1.5f;
            pessoa1.SetActive(false);
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
            pegaPessoa1 = true;
        }

        if (other.gameObject.CompareTag("ambulancia") && resgatandoPessoa1 == true)
        {
            devolvePessoaResgatada1 = true;
        }
    
    }

    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("pessoaFerida"))
        {
            pegaPessoa1 = false;    
        }
    }
    
}
