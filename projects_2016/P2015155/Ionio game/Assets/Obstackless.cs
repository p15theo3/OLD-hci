using UnityEngine;
using System.Collections;

public class Obstackless : MonoBehaviour
{
    public float speed;
    public float baseSpeed;
    public float scrollSpeed;
    public float rotationSpeed;
    public float scrollFactor;
    public Vector2 newspd;
    public Rigidbody2D rb;
    public GameManager gm;
    public int id;
    public SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        id = Random.Range(0, 4);
    }

    void FixedUpdate()
    {
        newspd = new Vector2(scrollSpeed, 0f);
        rotationSpeed = 0.5f;

        //if (!gm.lost)
        //{
            rb.velocity = newspd;

            scrollSpeed -= scrollFactor * Time.deltaTime;
            transform.Rotate(0, 0, -rotationSpeed);
        //}
        /*else
        {
            rb.velocity = Vector3.zero;
        }*/

        if (id == 0)
            sr.color = Color.black;

        if (id == 1)
            sr.color = Color.red;

        if (id == 2)
            sr.color = Color.green;

        if (id == 3)
            sr.color = Color.blue;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "kyrile")
        {
            if (id == col.gameObject.GetComponent<PlayerControl>().id)
            {
                Destroy(gameObject);
                //score += 1;
            }
            else if (id != 0)
                Destroy(gameObject);
            else
                Destroy(col.gameObject);
        }
    }
}