using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider healthSlider;

    public void SetMaxHealth(int health)
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;
        
        Debug.Log($"Health slider: {healthSlider.value} / {healthSlider.maxValue}");
    }

    public void UpdateHealthBar(int health)
    {
        healthSlider.value = health;
    }
}
