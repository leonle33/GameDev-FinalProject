using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class FloatingHealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    //[SerializeField] private Camera camera;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;



    public void UpdateHealthBar(float currentValue, float maxValue)
    {

        slider.value = currentValue / maxValue;
    }

    void Update()
    {
        Camera camera = Camera.main;
        transform.rotation = camera.transform.rotation;
        transform.position = target.position + offset;
    }
}
