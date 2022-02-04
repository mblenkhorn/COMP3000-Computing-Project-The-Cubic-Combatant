using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public CollectableManager manager;
    private float rotateSpeed = 90f;

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            manager.CollectObject();
            Destroy(gameObject);
        }
    }
}
