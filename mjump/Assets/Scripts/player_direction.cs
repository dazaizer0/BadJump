using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_direction : MonoBehaviour
{

    private LineRenderer lineRenderer;
    private SpriteRenderer sp;
    public Transform player;

    void Start()
    {

        lineRenderer = GetComponent<LineRenderer>();
        sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10.0f;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, player.position);

        if((Vector2.Distance(transform.position, player.position) < 1f) || Vector2.Distance(transform.position, player.position) > 11.1f)
        {

            sp.color = Color.red;
        }
        else
        {

            sp.color = Color.white;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        sp.color = Color.red;
    }
    void OnTriggerEnxit2D(Collider2D other)
    {
        
        sp.color = Color.white;
    }
}
