using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using UnityEngine;

public class Clicker : MonoBehaviour
{

    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;

    // Update is called once per frame
    void Update()
    {

        if(isBeingHeld == true)
        {

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);


        }

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);


            isBeingHeld = true;

            print(gameObject.name);
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;


    }
}
