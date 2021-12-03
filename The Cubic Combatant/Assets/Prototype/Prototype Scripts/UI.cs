using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text collectableText;
    public CollectableManager manager;

    public void UpdateText()
    {
        collectableText.text = manager.getCollectable().ToString();
    }
}
