using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QualityOptions : MonoBehaviour
{
    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
