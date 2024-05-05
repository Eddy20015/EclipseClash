using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Player pl;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pl = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
 
        float h = Input.GetAxis("Horizontal") * pl.movespeed; //left right
        float v = Input.GetAxis("Vertical") * pl.movespeed; //up down
        Vector3 vel = rb.velocity;
        vel.x = h;
        vel.y = v;
        rb.velocity = vel;
    }
}
