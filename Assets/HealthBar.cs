using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider healthSlider;
    public Slider easeHealthSlider;
    public float maxHealth = 100f;
    public float health;
    private float lerpSpeed = 0.05f;

    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthValue();
    }

    private void HealthValue()
    {
        CheckingHealthValue();
        ChangingHealthValue();
        ChangingInGameHealth();
    }


    private void CheckingHealthValue()
    {
        if (healthSlider.value != health)
        {
            healthSlider.value = health;
        }
    }

    private void ChangingHealthValue()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            TakeDamage(10);
        }
    }

    private void ChangingInGameHealth()
    {
        if (healthSlider.value != easeHealthSlider.value)
        {
            easeHealthSlider.value = Mathf.Lerp(easeHealthSlider.value, health, lerpSpeed);
        }
    }

    void TakeDamage(float damage)
    {
        health -= damage;
    }


}
