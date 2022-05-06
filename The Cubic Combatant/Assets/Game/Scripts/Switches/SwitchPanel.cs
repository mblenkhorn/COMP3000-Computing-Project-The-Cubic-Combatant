using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPanel : MonoBehaviour
{
    public Material switchOnMaterial;

    public MeshRenderer switchRenderer;

    public static bool isPressed = false;

    public PlatformEvent platformEvent;

    private void Start()
    {
        switchRenderer = GetComponent<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !isPressed)
        {
            setMaterial();
            platformEvent.beginEvent();
        }
        else
        {
            Debug.Log("You've already pressed me!");
        }
        
        
    }

    public void setMaterial()
    {
        switchRenderer.material = switchOnMaterial;
        isPressed = true;
        Debug.Log("You've pressed me!");
    }
}
