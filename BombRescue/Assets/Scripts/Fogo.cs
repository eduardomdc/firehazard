using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
public class Fogo : MonoBehaviour
{
    public float holdThrow=1.5f;
    float holdTimer;
    private bool colisao, fogoApagado;
    // Start is called before the first frame update

    void Start()
    {
        this.holdTimer = holdThrow;
    }
    void Update()
    {
        if(Input.GetButton("Fire1") && this.colisao == true)
        {
            this.holdTimer-=Time.deltaTime   ;
            if (this.holdTimer<0)
            {
                Debug.Log("foguinnn");
                ApagaFogo();
                this.holdTimer=holdThrow;
            }
        }

        if(this.fogoApagado == true)
        {
            Invoke("AcendeFogo", 5.5f);
        }
    }
    public void OnTriggerStay2D(Collider2D other) {

        if (other.gameObject.CompareTag("gasExtintor"))
        {
            Debug.Log("colidindo");
            this.colisao = true;
        }
    }    
    public void OnTriggerExit2D(Collider2D other)
    { 
        if (other.gameObject.CompareTag("gasExtintor"))
        {
            Debug.Log("colidindo");
            this.colisao = false;
        }
    }    

    public void ApagaFogo()
    {
        this.gameObject.SetActive(false);
        this.fogoApagado = true;
    }
 
 public void AcendeFogo()
 {
    this.gameObject.SetActive(true);
    this.fogoApagado = false;
 }
 //a
}
