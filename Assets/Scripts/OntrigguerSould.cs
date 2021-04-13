using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntrigguerSould : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "souldBlue")
        {
            Destroy(other.gameObject);
        }
    }
}
