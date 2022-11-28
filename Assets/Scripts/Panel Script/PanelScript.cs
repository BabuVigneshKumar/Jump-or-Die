using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel()
    {
        if(Panel != null)
        {
            bool isActivate = Panel.activeSelf;
            Panel.SetActive(!isActivate);
        }
    }
   
}
