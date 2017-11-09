using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace prjTeleporter
{
    public class scrMyBullet : scrObjBase
    {

        // Use this for initialization
        void Start ()
        {
		
        }
	
        // Update is called once per frame
        void Update ()
        {
            GameObject Target = null;
            float mostNearDist = 999999.0f;

            foreach (GameObject Candidate in scrEmShipBase.EmShips) {
                float dist = Vector3.Distance (gameObject.transform.position, Candidate.transform.position);
                if (dist < mostNearDist) {
                    mostNearDist = dist;
                    Target = Candidate;
                }
            }

            if (Target == null) {
                //  画面外へ向けて
                //  mostNearDist = 
            }

        }
    }
}