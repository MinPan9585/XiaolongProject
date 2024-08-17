using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public GameObject winUI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winUI.SetActive(true);
            Destroy(gameObject);
            Cursor.lockState = CursorLockMode.None;
            //win

        }
    }
}
