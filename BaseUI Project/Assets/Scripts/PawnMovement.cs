using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnMovement : MonoBehaviour 
{
    float time = 3;
    bool foward;
    bool back;

	void Start () 
    {
        foward = true;
        back = false;
	}
	
	void Update () 
    {
        time -= 1 * Time.deltaTime;

        if (time > 0 && foward == true)
        {
            this.transform.position += transform.forward * 10 * Time.deltaTime;
        }
        else if (time > 0 && back == true)
        {
            this.transform.position += -transform.forward * 10 * Time.deltaTime;
        }

        if (time <= 0 && foward == true)
        {
            foward = false;
            back = true;
            time = 3;
        }
        else if (time <= 0 && back == true)
        {
            foward = true;
            back = false;
            time = 3;
        }
	}
}
