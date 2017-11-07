using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace prjTeleporter
{

    public class scrClickMark : MonoBehaviour
    {

        Vector3 scale;

        // Use this for initialization
        void Start()
        {
            scale = gameObject.transform.localScale;
        }
	
        // Update is called once per frame
        void Update()
        {
            scale.x -= 0.01f;
            scale.y -= 0.01f;
            scale.z -= 0.01f;
            transform.localScale = scale;

            if (scale.x <= 0.0f) {
                gameObject.transform.SetParent (null);
                Destroy (gameObject);
            }
        }
    }
}