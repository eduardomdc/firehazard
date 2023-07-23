using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //Código pra camera seguir o jogador
    public PlayerPerna player;
    void Update()
    {
        this.transform.position = player.transform.position;
    }
}
