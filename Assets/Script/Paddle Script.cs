using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public KeyCode input;
    public HingeJoint hinge;
    public float springPower;

    public void Start()                    
    {
        hinge = GetComponent<HingeJoint>();
    }

    
    public void Update()
    {
        ReadInput();
    }
    public void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;
        
        if (Input.GetKey(input))
        {
            jointSpring.spring = springPower;
        }
        else
        {
            jointSpring.spring = 0;
        }

        hinge.spring = jointSpring;
    }
    
}
