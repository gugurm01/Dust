using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int vidas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
