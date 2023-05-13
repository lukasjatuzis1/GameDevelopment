using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectBehaviour : MonoBehaviour
{

    public Slider slider;
    float sliderValue;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        sliderValue = slider.value;
        transform.localScale = new Vector3(sliderValue, sliderValue, sliderValue);

    }

    public void changeColour()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void EnableRigidbody()
    {
        GetComponent<Rigidbody>().useGravity = true;
    } 
}
