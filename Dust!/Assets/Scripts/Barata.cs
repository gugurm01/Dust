using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barata : MonoBehaviour
{
    public float speed = 2f;
    public float height = 0.05f;
    float startY;
    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        var newY = startY + height * Mathf.Sin(Time.time * speed); 
        transform.position = new Vector2(pos.x, newY);
    }
}
