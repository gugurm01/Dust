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
    public int timer;
    public float time;

    


    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemies"))
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
        }
    }


}
