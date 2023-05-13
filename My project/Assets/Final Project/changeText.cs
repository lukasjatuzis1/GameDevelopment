using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeText : MonoBehaviour
{
    private Text yourText; // Insert your text object inside unity inspector

    void Start()
    {
        yourText.enabled = false; // You may need to use .SetActive(false);
    }


    // Assuming you're using a 2D platform
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "gameObject")
        {
            // This is where you make your text object appear on screen
            yourText.enabled = false; // May need to use .SetActive(true);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Here is where you make the text disappear off screen
        if (collision.gameObject.tag == "gameObject")
        {
            yourText.enabled = true; // May need to use .SetActive(false);
        }
    }
}
