using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnContactWithWalls : MonoBehaviour
{
    [SerializeField]
    Color collisionColor;
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    private void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = collisionColor;
    }
}
