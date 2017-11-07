using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrHitTest : MonoBehaviour
{

    public GameObject prefabClickMark;

    public GameObject objWorld;

    // Use this for initialization
    void Start()
    {
		
    }

    enum eMouseButton
    {
        left = 0,
        right = 1,
        center = 2,
        wheel = center
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown ((int)eMouseButton.left)) {
            Vector3 posMouse = Input.mousePosition;
            Debug.Log ("left button down in (" + posMouse.x + ", " + posMouse.y + ", " + posMouse.z + ")");
        }

        if (Input.GetMouseButtonUp ((int)eMouseButton.left)) {
            Vector3 posMouse = Input.mousePosition;
            Debug.Log ("left button up in (" + posMouse.x + ", " + posMouse.y + ", " + posMouse.z + ")");
            Vector3 posScreen = Camera.main.ScreenToWorldPoint (posMouse);
            posScreen.z = 0;
            Instantiate (prefabClickMark, posScreen, Quaternion.identity);

        }

    }
}
