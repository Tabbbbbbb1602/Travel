using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.tag == "Player")
        {
            UIController.DiaMondCollected();
            gameObject.SetActive(false);
        }

    }

}
