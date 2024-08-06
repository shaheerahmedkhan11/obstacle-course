using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float xValue = 0f;

    [SerializeField]
    private float yValue = 0.01f;

    [SerializeField]
    private float zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The game has now commenced!");
    }

    // Update is called once per frame
    void Update()
    {
        print("Activated");
        transform.Translate(xValue, yValue, zValue);
    }
}
