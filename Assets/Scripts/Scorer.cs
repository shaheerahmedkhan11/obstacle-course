using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumps = 0;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("You have bumped into a wall " + bumps + " times");
        bumps++;
    }


}
