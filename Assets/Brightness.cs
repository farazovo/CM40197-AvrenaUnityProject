using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class Brightness : MonoBehaviour
{
    // from https://www.youtube.com/watch?v=XiJ-kb-NvV4
    public Slider brightnessslider;
    public PostProcessProfile brightness;
    public PostProcessLayer postprocesslayer;

    AutoExposure exposure;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        brightness.TryGetSettings(out exposure);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void adjustbrightness(float value)
    {
        if (value != 0)
        {
            exposure.keyValue.value = value;
        }
        else
        {
            exposure.keyValue.value = .05f;
        }
    }
}
