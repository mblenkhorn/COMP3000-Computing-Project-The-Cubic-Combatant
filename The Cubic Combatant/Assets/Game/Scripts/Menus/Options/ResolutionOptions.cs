using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResolutionOptions : MonoBehaviour
{
    Resolution[] resolutions;

    public TMP_Dropdown resolutionsDropDown;


    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionsDropDown.ClearOptions();

        int currentResolutionIndex = 0;
        List<string> options = new List<string>();

        GatherResolutions(options, currentResolutionIndex);

        resolutionsDropDown.AddOptions(options);
        resolutionsDropDown.value = currentResolutionIndex;
        resolutionsDropDown.RefreshShownValue();
    }

    public void GatherResolutions(List<string> options, int currentResolutionIndex)
    {
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.width &&
                resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }
    }

    public void setResolutions(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
