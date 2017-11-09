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

    static private     Rect worldRect;
    //メインカメラからワールド座標系の描画範囲を求める
    public static Rect WorldRect {
        get{ return WorldRect; }
    }
}
