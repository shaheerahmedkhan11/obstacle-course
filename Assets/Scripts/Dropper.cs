using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;

    [SerializeField]
    float TimeForDropping = 3f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        rigidbody.useGravity = false;
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeForDropping)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
