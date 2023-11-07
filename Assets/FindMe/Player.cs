using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 newPosition = transform.position + new Vector3(moveX, 0f, moveZ) * speed * Time.deltaTime;

        transform.position = newPosition;
    }
}