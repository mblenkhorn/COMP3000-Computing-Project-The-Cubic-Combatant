using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    //public Text collectableText;
    public CollectableManager manager;

    public TMP_Text collectableTextPro;

    public void UpdateText()
    {
        //collectableText.text = manager.getCollectable().ToString();

        collectableTextPro.text = manager.getCollectable().ToString();
    }
}
