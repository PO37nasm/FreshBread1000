using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckUnloader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Duck"))
        {
            GameManager.AddDuck();
            Destroy(other.gameObject);
        }
    }
}
