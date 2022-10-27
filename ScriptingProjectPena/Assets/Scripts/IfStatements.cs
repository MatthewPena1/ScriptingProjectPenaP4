using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Action is called and performed every frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {   // If the coffee's temperature is greater than the highest temp. limit...
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot.");
        }
        // If the coffee's temperature is lower than the lowest temp. limit...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }
        // If the coffee's temperature is neither of these conditions...
        else
        {
            print("Coffee is just right.");
        }
    }
}
