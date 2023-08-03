using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Resgate : MonoBehaviour
{
    public float resgate;
    public bool resgatados;
    public GameObject torso;
    public GameObject mae, maeResgatada, pai, paiResgatado, filha, filhaResgatada, filho, filhoResgatado, missaoConcluida;
    public Sprite SpriteResgatandoMae, SpriteResgatandoPai, SpriteResgatandoFilha, SpriteResgatandoFilho, torsoPadrao;
    public GameObject ambulancia;
    private bool pegaMae, devolveMaeResgatada, resgatandoMae, pegaPai, devolvePaiResgatado, resgatandoPai, pegaFilha, devolveFilhaResgatada, resgatandoFilha, pegaFilho, devolveFilhoResgatado, resgatandoFilho;
    // Start is called before the first frame update
    // Update is called once per frame

    void Update()
    {   
        //Mae
        Debug.Log(pegaMae);
        if(Input.GetKeyDown("e") && pegaMae == true)
        {
            resgatandoMae = true;
            torso.GetComponent<SpriteRenderer>().sprite = SpriteResgatandoMae;
            this.gameObject.GetComponent<PlayerPerna>().speed = 1.5f;
            mae.SetActive(false);
        }
        if(Input.GetKeyDown("e") && devolveMaeResgatada == true)
        {
            torso.GetComponent<SpriteRenderer>().sprite = torsoPadrao;
            this.gameObject.GetComponent<PlayerPerna>().speed = 3.5f;
            maeResgatada.SetActive(true);
            pegaMae = false;
            resgatandoMae = false;
            devolveMaeResgatada = false;
            this.resgate +=1;
        }
        //Pai
            if(Input.GetKeyDown("e") && pegaPai == true)
        {
            resgatandoPai = true;
            torso.GetComponent<SpriteRenderer>().sprite = SpriteResgatandoPai;
            this.gameObject.GetComponent<PlayerPerna>().speed = 1.5f;
            pai.SetActive(false);
        }
        
        if(Input.GetKeyDown("e") && devolvePaiResgatado == true)
        {
            torso.GetComponent<SpriteRenderer>().sprite = torsoPadrao;
            this.gameObject.GetComponent<PlayerPerna>().speed = 3.5f;
            paiResgatado.SetActive(true);
            pegaPai = false;
            resgatandoPai = false;
            devolvePaiResgatado = false;
            this.resgate +=1;
        }
        //Filha  
        if(Input.GetKeyDown("e") && pegaFilha == true)
        {
            resgatandoFilha = true;
            torso.GetComponent<SpriteRenderer>().sprite = SpriteResgatandoFilha;
            this.gameObject.GetComponent<PlayerPerna>().speed = 1.5f;
            filha.SetActive(false);
        }
        
        if(Input.GetKeyDown("e") && devolveFilhaResgatada == true)
        {
            torso.GetComponent<SpriteRenderer>().sprite = torsoPadrao;
            this.gameObject.GetComponent<PlayerPerna>().speed = 3.5f;
            filhaResgatada.SetActive(true);
            pegaFilha = false;
            resgatandoFilha = false;
            devolveFilhaResgatada = false;
            this.resgate +=1;
        } 
        //Filho
        if(Input.GetKeyDown("e") && pegaFilho == true)
        {
            resgatandoFilho = true;
            torso.GetComponent<SpriteRenderer>().sprite = SpriteResgatandoFilho;
            this.gameObject.GetComponent<PlayerPerna>().speed = 1.5f;
            filho.SetActive(false);
        }
        
        if(Input.GetKeyDown("e") && devolveFilhoResgatado == true)
        {
            torso.GetComponent<SpriteRenderer>().sprite = torsoPadrao;
            this.gameObject.GetComponent<PlayerPerna>().speed = 3.5f;
            filhoResgatado.SetActive(true);
            pegaFilho = false;
            resgatandoFilho = false;
            devolveFilhoResgatado = false;
            this.resgate +=1;
        }
        if(this.resgate == 4)
        {
            resgatados = true;
        }

        if(resgatados == true)
        {
            missaoConcluida.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void OnTriggerStay2D(Collider2D other) 
    {
        //Mae
        if (other.gameObject.CompareTag("maeFerida"))
        {
            pegaMae = true;
        }
        if (other.gameObject.CompareTag("ambulancia") && resgatandoMae == true)
        {
            devolveMaeResgatada = true;
        }
        //Pai
        if (other.gameObject.CompareTag("paiFerido"))
        {
            pegaPai = true;
        }
        if (other.gameObject.CompareTag("ambulancia") && resgatandoPai == true)
        {
            devolvePaiResgatado = true;
        }
        //Filha
        if (other.gameObject.CompareTag("filhaFerida"))
        {
            pegaFilha = true;
        }
        if (other.gameObject.CompareTag("ambulancia") && resgatandoFilha == true)
        {
            devolveFilhaResgatada = true;
        }
        //Filho
         if (other.gameObject.CompareTag("filhoFerido"))
        {
            pegaFilho = true;
        }
        if (other.gameObject.CompareTag("ambulancia") && resgatandoFilho == true)
        {
            devolveFilhoResgatado = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other) 
    {
        //Mae
        if(other.gameObject.CompareTag("maeFerida"))
        {
            pegaMae = false;    
        }
        //Pai
            if(other.gameObject.CompareTag("paiFerido"))
        {
            pegaPai = false;    
        }
        //Filha
        if(other.gameObject.CompareTag("filhaFerida"))
        {
            pegaFilha = false;    
        }
        //Filho
        if(other.gameObject.CompareTag("filhoFerido"))
        {
            pegaFilho = false;    
        }
    }

}
