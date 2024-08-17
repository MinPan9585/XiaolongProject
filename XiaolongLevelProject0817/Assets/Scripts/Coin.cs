using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coinFX;
    public AudioClip coinClip;
    bool destroy = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !destroy)
        {
            Instantiate(coinFX, transform.position, Quaternion.identity);
            this.GetComponent<AudioSource>().PlayOneShot(coinClip);
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.transform.GetChild(0).gameObject.SetActive(false);
            destroy = true;
            Destroy(gameObject,2);
            other.gameObject.GetComponent<Player>().coinNum++;
        }
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward, 90 * Time.deltaTime);
    }
}
