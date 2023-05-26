using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{

    private bool canMove = false;
    public Vector3 moveIncrement;
    public GameObject box;

    private Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = box.transform.position;
    }

    // Update is called once per frame
    void Update() { 
        if (canMove && (box.transform.position - startingPos).x > -10)
        {
            Debug.Log((box.transform.position - startingPos).x);
            box.transform.position += moveIncrement;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        canMove = true;
        Debug.Log("triggered");
        Debug.Log(canMove);
    }
}
