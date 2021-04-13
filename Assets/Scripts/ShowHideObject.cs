using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideObject : MonoBehaviour {

    public GameObject Object;

    public void ShowObject()
    {
        Object.SetActive(true);
    }

    public void HideObject()
    {
        Object.SetActive(false);
    }
}
