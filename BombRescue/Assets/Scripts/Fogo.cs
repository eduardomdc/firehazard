using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
public class Fogo : MonoBehaviour
{
    public float holdThrow=2f;
    float holdTimer;
    private bool colisao;
    // Start is called before the first frame update

    void Start()
    {
        holdTimer = holdThrow;
    }
    void Update()
    {
        if(Input.GetButton("Fire1") && colisao == true)
        {
            holdTimer-=Time.deltaTime   ;
            if (holdTimer<0)
            {
                Debug.Log("foguinnn");
                ApagaFogo();
            }
        }
    }
    public void OnTriggerStay2D(Collider2D other) {

        if (other.gameObject.CompareTag("gasExtintor"))
        {
            Debug.Log("colidindo");
            colisao = true;
        }
    }    
    
    public void ApagaFogo()
    {
        this.gameObject.SetActive(false);
    }
 
}
