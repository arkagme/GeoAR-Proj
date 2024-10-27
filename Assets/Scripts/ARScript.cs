using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARScript : MonoBehaviour
{
    public GameObject[] allObjects;
    public void EnableOnlyOne(GameObject objectToEnable)
    {
        foreach (GameObject obj in allObjects)
        {
            obj.SetActive(obj == objectToEnable);
        }
    }

}
