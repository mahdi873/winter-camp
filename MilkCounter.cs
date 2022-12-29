using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MilkCounter : MonoBehaviour
{
    public int milkCount = 0;
    public Textmilk milk;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Runner")
        {
            milkCount++;
            milk.text = "Milk = " + milkCount;
        }
    }
}
