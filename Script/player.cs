using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    
    //private Rigidbody2D playerRB;
    //public float velocidade;


    //private SpriteRenderer playerSprite; //mudar lado
    //public bool flipX; //mudar lado

    // Start is called before the first frame update
    void Start()
    {
        
        
        //playerRB = GetComponent<Rigidbody2D>();
        //playerSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            velocidade = velocidade * -1;//vai para trás
            //flipX = !flipX; //mudar lado
            //playerSprite.flipX = flipX; //mudar lado

        }
        playerRB.velocity = new Vector2(velocidade, playerRB.velocity.y);//Vai para frente*/
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if(colisao.gameObject.tag == "bateu")
        {
            SceneManager.LoadScene("GameOver");
            print("Bateu!");
        }
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if(colisao.gameObject.tag == "estacionou")
        {
            pontuacao.pontos += 1;
            print("Estacionou!");
        }
    }

    public void voltou()
    {
        SceneManager.LoadScene("SampleScene");
        print("Bateu!");
    }
}

