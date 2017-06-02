using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour {

    new Rigidbody rigidbody;
    public float speed = 2f;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0f, v);
        rigidbody.MovePosition(transform.position + (dir * Time.deltaTime * speed));

    }
}
