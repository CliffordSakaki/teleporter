using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCommon : MonoBehaviour
{

    // Use this for initialization
    void Start ()
    {
        //worldRect = Camera.main.w;
    }
	
    // Update is called once per frame
    void Update ()
    {
		
    }

    //メインカメラからワールド座標系の描画範囲を求める
    static private     Rect worldRect2D;

    public static Rect WorldRect2D {
        get{ return worldRect2D; }
    }
}
