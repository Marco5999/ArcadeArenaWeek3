using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public float flashSpeed = 10f; // Adjust the speed of the flashing
    public float maxIntensity = 8f; // Maximum intensity of the light
    public float minIntensity = 0f; // Minimum intensity of the light

    private Light pointLight;
    private bool isLightOn = false;

    void Start()
    {
        pointLight = GetComponent<Light>();
        StartCoroutine(Flash());
    }

    IEnumerator Flash()
    {
        while (true)
        {
            if (isLightOn)
            {
                pointLight.intensity = minIntensity;
            }
            else
            {
                pointLight.intensity = maxIntensity;
            }

            isLightOn = !isLightOn;
            yield return new WaitForSeconds(1f / flashSpeed);
        }
    }
}
