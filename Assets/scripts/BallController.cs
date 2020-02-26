using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    OrientationController controller;


    // Start is called before the first frame update
    void Start()
    {
        controller = new OrientationController("COM4");
    }

    // Update is called once per frame
    void Update()
    {
        string keyPressed = controller.getKey();

        Debug.Log(keyPressed);
    }
}