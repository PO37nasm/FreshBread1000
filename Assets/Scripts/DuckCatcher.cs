using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckCatcher : MonoBehaviour
{
    //[SerializeField]
    //private Collider collider;
    [SerializeField]
    private Transform caughtDuckSpawnPoint;
    [SerializeField]
    private GameObject duck;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Colliding...");
        if (collision.gameObject.CompareTag("Duck")) 
        {
            //add a duck to the boat and Destroy the duck in the water
            Debug.Log("Caught a Duck");
            Instantiate<GameObject>(duck, caughtDuckSpawnPoint);
            Destroy(collision.gameObject);
            FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Interactables/PickupItem", gameObject);
        }
    }
}
