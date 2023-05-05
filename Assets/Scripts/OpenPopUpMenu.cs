using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPopUpMenu : MonoBehaviour
{
    [SerializeField] GameObject popUpMenu;
    public void oPopUpMenu()
    {
        if (popUpMenu.activeSelf)
            popUpMenu.SetActive(false);
        else
            popUpMenu.SetActive(true);
    }
}
