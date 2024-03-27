using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private int vidas;
    [SerializeField] int maxVidas;
    [SerializeField] int minVidas;
    
    [SerializeField] float speed;
    private Transform target;

    public ParticleSystem particula;
    public int score;
    public int scoreGain;
    public Text scoreText;

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
           
            ParticleSystem explos�o = Instantiate(this.particula, this.transform.position, Quaternion.identity);
            Destroy(explos�o.gameObject, 1f);
            Destroy(gameObject);
        }    
    }

    private void OnMouseDown()
    {
        
        vidas--;
        print(vidas)
;    }

    

    

    public void FollowPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
