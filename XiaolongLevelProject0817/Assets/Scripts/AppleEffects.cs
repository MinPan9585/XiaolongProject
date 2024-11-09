using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleEffects : MonoBehaviour
{
    public GameObject applevfx;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(applevfx, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
