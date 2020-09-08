using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locater : MonoBehaviour
{

    private runner Runner;
    private Vector3 lastPosition;
    private float distance;

    void Start()
    {
        Runner = FindObjectOfType<runner>();
        lastPosition = Runner.transform.position;
    }

    void Update()
    {
        distance = Runner.transform.position.x - lastPosition.x;
        transform.position = new Vector3(
            transform.position.x + distance,
            transform.position.y,
            transform.position.z
        );
        lastPosition = Runner.transform.position;
    }
}

    

