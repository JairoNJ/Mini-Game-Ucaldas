using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulMovement : MonoBehaviour
{

    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBouns;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        screenBouns = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Debug.Log(-screenBouns.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -screenBouns.y * 2 )
        {
            Destroy(this.gameObject);
        }
    }
}
