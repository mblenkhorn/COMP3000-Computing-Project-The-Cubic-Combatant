using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 90f;

    // Update is called once per frame
    void Update()
    {
        RotateObject();
    }

    public void RotateObject()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
