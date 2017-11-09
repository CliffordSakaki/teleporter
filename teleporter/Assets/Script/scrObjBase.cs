using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace prjTeleporter
{
    public class scrObjBase : MonoBehaviour
    {

        // Use this for initialization
        void Start ()
        {
		
        }
	
        // Update is called once per frame
        void Update ()
        {
		
        }


        public void setHeadToTarget (Vector3 posTarget)
        {
            Head = posTarget - transform.position;
        }

        private Vector3 head;

        public Vector3 Head {

            set {//進行方向を表す単位ベクトル 
                head = Vector3.Normalize (value);
            }
            get{ return head; }
        }

        private float speed;

        public float Speed {
            set{ speed = value; }
            get{ return speed; }
        }

        public Vector3 Vector {
            get{ return Head * Speed; }
        }

    }
}