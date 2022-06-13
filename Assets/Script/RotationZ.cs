using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationZ : MonoBehaviour
{
    [SerializeField] private float rotZ;
    [SerializeField] private float rotationSpeed;
    public bool clockwiseRotation;

    private void Update()
    {
        if (clockwiseRotation == false)
        {
            rotZ += Time.deltaTime * rotationSpeed;
        }
        else
        {
            rotZ += -Time.deltaTime * rotationSpeed;
        }
        
        transform.rotation = Quaternion.Euler(0,0,rotZ);
    }
}
