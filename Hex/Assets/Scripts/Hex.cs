using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex
{
    //Q + R + S = 0
    //S = -(Q + R)

    public readonly int Q;  //col
    public readonly int R;  //row
    public readonly int S;

    static readonly float WIDTH_MULTIPLER = Mathf.Sqrt(3) / 2;

    public Hex(int q, int r){

        this.Q = q;
        this.R = r;
        this.S = -(q + r);

    }

    //Return the world-space position of tihs hex
    public Vector3 Position(){

        float radius = 1f;
        float height = radius * 2;
        float width = WIDTH_MULTIPLER * height;

        float horiz = width;
        float vert = height * 0.656f;

        return new Vector3(
                        horiz * (this.Q + this.R/2f),
                        0,
                        vert * this.R);
    }

}
