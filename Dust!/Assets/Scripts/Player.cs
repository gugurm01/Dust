using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;
    float horizontal;
    float vertical;
    public static int dano;
    public GameObject gameOver;

    void Start()
    {
        dano = 1;
    }


    void Update()
    {
        /*horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        body.velocity = new Vector2(speed * horizontal, speed * vertical);
        */

        
    }
    public void Voltar()
    {
        dano = 1;
    }

    public void IDK()
    {
        dano *= 2;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemies"))
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
        }
    }


}
