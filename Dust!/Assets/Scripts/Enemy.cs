using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int vidas;
    [SerializeField] int maxVidas;
    [SerializeField] int minVidas;
    
    [SerializeField] float speed;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        vidas = Random.Range(minVidas, maxVidas);
        print(vidas);
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();

        if(vidas == 0)
        {
            Destroy(gameObject);
        }    
    }

    private void OnMouseDown()
    {
        vidas--;
        print(vidas)
;    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            print("morreu");
        }
    }

    

    public void FollowPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
