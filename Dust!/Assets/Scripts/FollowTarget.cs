using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowTarget : MonoBehaviour
{
    public GameObject formigaA, formigaB, formigaC, formigaD;
    
    [SerializeField] float speed;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        if(formigaA == null & formigaB == null & formigaC == null & formigaD == null)
        {
            Destroy(this.gameObject);
        }
    }



    public void FollowPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
