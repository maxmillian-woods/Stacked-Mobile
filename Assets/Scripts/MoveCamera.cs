using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        speed = 6f;
        if (Input.GetButtonDown("Fire1"))
        transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
    }
}
