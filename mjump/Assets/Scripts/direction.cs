using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction : MonoBehaviour
{

    private LineRenderer lineRenderer;
    public Transform player;

    void Start()
    {

        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10.0f;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, player.position);
    }
}
