using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnContactWithWalls : MonoBehaviour
{
    [SerializeField]
    Color collisionColor;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = collisionColor;
    }
}
