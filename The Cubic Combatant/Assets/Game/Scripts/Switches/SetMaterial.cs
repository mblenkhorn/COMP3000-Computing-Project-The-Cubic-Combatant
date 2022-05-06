using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterial : MonoBehaviour
{
    public Material switchOnMaterial;

    public MeshRenderer switchRenderer;

    private void Start()
    {
        switchRenderer = GetComponent<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        setMaterial();
    }

    public void setMaterial()
    {
        switchRenderer.material = switchOnMaterial;
    }
}
