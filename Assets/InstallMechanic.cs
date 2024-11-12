using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstallMechanic : MonoBehaviour
{
    public bool install = false;
    public float maxInstall = 100f;
    public float installValue;
    public Slider installSlider;
    public Slider easeInstallSlider;
    private float lerpSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        installValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (installSlider.value != installValue)
        {
            installSlider.value = Mathf.Lerp(installSlider.value, installValue, lerpSpeed);
        }

        if (!install && installValue == maxInstall)
        {
            install = true;
        }

        if (install && installValue == 0)
        {
            install = false;
        }

        if (install)
        {
            DecreaseInstall(20);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                IncreaseInstall(10);
            }
        }
    }

    void IncreaseInstall (float meterChange)
    {
        installValue += meterChange;
    }

    void DecreaseInstall (float meterChange)
    {
        installValue -= meterChange * Time.deltaTime;
    }
}
