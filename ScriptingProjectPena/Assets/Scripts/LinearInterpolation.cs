using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    /*

    // result = 4
    float result = Mathf.Lerp(3f, 5f, 0.5f);

    // The Mathf.Lerp function takes 3 float parameters: one representing the value to interpolate from; another representing
    // the value to interpolate to and a final float representing how far to interpolate

    Vector3 from = new Vector3(1f, 2f, 3f);
    Vector3 to = new Vector3(5f, 6f, 7f);

    // result = (4, 5, 6)

    Vector3 result = Vector3.Lerp(from, to, 0.75f);

    //Vector3.Lerp works in the same manner as Mathf.Lerp; the difference is that the 'from' and 'to' values are of type Vector3
    //The third parameters in each case still presents how much to interpolate; result is a vector that is some percentage of the way between
    //the two vectors


    // Update is called once per frame
    void Update()
    {
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);

        //The intensity would happen per second rather than per frame (second light.intensity vs first light intensity, respectively)
    }
    
    */
}
