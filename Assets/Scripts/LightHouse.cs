using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHouse : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 1;
    [SerializeField]
    private Transform pivot;

    private void FixedUpdate()
    {
        pivot.Rotate(new Vector3(0, rotateSpeed, 0));
    }
}
