using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{

    public Rigidbody2D rb;
    public float jumpSpeed;
    public int id = 2;
    public SpriteRenderer sr;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        id = 2;
        sr.color = Color.green;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
            rb.velocity += new Vector2(0, jumpSpeed);

        if (Input.GetKey(KeyCode.R))
        {
            id = 1;
            sr.color = Color.red;
        }

        if (Input.GetKey(KeyCode.G))
        {
            id = 2;
            sr.color = Color.green;
        }

        if (Input.GetKey(KeyCode.B))
        {
            id = 3;
            sr.color = Color.blue;
        }
    }
}