using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBlock : MonoBehaviour
{
    public float speed;
    public float speedmultiplier = 20.0f;
    public float smoothfactor = 3.0f; 
    public float tiltAngle = 180.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = Input.GetAxis("Vertical");
        transform.Translate(-Vector3.forward * speed * Time.deltaTime*speedmultiplier);

        float rotationSpeed = Input.GetAxis("Horizontal") * tiltAngle;
        Quaternion rotationTarget = Quaternion.Euler(0, rotationSpeed, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotationTarget, Time.deltaTime * smoothfactor);
    }
}
