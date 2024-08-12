using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
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
}
