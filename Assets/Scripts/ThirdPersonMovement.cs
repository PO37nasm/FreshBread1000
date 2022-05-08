using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody body;
    [SerializeField]
    private float speed = 6f;
    [SerializeField]
    private float rotationTorque = 0.1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        //Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (vertical >= 0.1f)
        {
            //float targetAngle = Mathf.Atan2(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.z) * Mathf.Rad2Deg;
            //body.AddTorque(0f, targetAngle * rotationTorque, 0f);

            Vector3 facing = transform.forward;
            Debug.Log(facing);
            body.AddForce( facing * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (horizontal >= 0.1f || horizontal <= -0.1f)
        {
            body.AddTorque(0f, horizontal, 0f);
        }
        
    }

}
