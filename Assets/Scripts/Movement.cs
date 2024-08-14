using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float Maxbound_X, Minbound_X, Maxbound_Z, Minbound_Z;

    [SerializeField]
    float speed = 10f;

    private Vector3 tempos;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        AntiGlitch();
    }
    public void PrintInstructions()
    {
        Debug.Log("The game has now commenced!");
        print("Use the keys WASD to move the player");
    }
    public void MovePlayer()
    {
        //variables for moving the player
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(xValue, 0, zValue);
    }
    private void AntiGlitch()
    {
        tempos = transform.position;

        if (tempos.x > Maxbound_X)
            tempos.x = Maxbound_X;
        else if (tempos.x < Minbound_X)
            tempos.x = Minbound_X;
        else if (tempos.z > Maxbound_Z)
            tempos.z = Maxbound_Z;
        else if (tempos.z < Minbound_Z)
            tempos.z = Minbound_Z;

        transform.position = tempos;
    }
}
