using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Animator anim;
    private Rigidbody _rigidbody;
    public AnimationClip _animation;

    private void Start()
    {
         anim = GetComponentInChildren<Animator>();
         _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (_rigidbody.velocity.magnitude>0)
        {
           anim.SetBool("Run",true); 
        }
        else
        {
            anim.SetBool("Run",false); 
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, 0.5f, 0);
        }
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 newPosition = transform.position + new Vector3(moveX, 0f, moveZ) * speed * Time.deltaTime;

        transform.position = newPosition;
    }
}