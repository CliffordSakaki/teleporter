using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace prjTeleporter
{

    public class scrEmShipBase : MonoBehaviour
    {
        public  static List<GameObject> EmShips = new List<GameObject> ();

        // Use this for initialization
        void Start()
        {
            EmShips.Add (gameObject);
        }
	
        // Update is called once per frame
        void Update()
        {
		
        }

        protected void Term()
        {
            EmShips.Remove (gameObject);
        }
    }
}