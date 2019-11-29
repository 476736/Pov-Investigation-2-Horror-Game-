using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkScare : MonoBehaviour
{
    public GameObject scareTrigger;
    public GameObject jumpCube;

    private void Start()
    {
        jumpCube.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider scareTrigger)
    {
        jumpCube.gameObject.SetActive(true);
        OffAndOn();
    }
    IEnumerator OffAndOn()
    {
        jumpCube.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        jumpCube.gameObject.SetActive(false);
        yield return new WaitForSeconds(1);
    }
}
