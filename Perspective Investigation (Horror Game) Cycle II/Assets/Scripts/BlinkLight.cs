using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkLight : MonoBehaviour
{
    public GameObject blinkLight;
    Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
        StartCoroutine(OffAndOn());

    }

    IEnumerator OffAndOn()
    {
        while (true)
        {
            myLight.enabled = true;
            yield return new WaitForSeconds(1);
            myLight.enabled = false;
            yield return new WaitForSeconds(1);
        }
    }
}
