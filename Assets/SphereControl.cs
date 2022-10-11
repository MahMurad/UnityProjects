using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    public Transform target;
    public float speed = 0.025f;
    public Vector3 position;

    // Update is called once per frame
    void Update()
    {
        position.x = Input.GetAxis("Horizontal");
        position.z = Input.GetAxis("Vertical");

        target.Translate(position.x*speed , 0, position.z*speed);
    }
}
