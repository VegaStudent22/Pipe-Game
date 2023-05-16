using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    int[] rotations = {0,90,180,270};

    public float CorrectRotation;
    bool IsPlaced = false;

    private void Start()
    {

    }


    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0,0,90));

        if(transform.eulerAngles.z == CorrectRotation && IsPlaced == false)
        {
            IsPlaced = true;
        }
        else if(IsPlaced == true)
        {
            IsPlaced = false;
        }

    }
}
