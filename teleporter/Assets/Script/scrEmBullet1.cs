using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace prjTeleporter
{

    public class scrEmBullet1 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
		
        }

        // Update is called once per frame
        void Update()
        {
		
        }


        public void setHeadToTarget(Vector3 posTarget)
        {
            Head = posTarget - transform.position;
        }

        //進行方向を表す単位ベクトル
        private Vector3 head;

        public Vector3 Head {
            set {
                head = Vector3.Normalize (value);
            }
            get{ return head; }
        }

        //移動速度
        private float speed;

        public float Speed {
            set{ speed = value; }
            get{ return speed; }
        }

        //移動ベクトル
        public Vector3 Vector {
            get{ return Head * Speed; }
        }

    }
}