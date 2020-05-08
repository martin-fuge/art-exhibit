using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
        void Start()
    {
        Panel.SetActive(false);
    }
    public void OpenPanel()

    {
        if (Panel != null)
        {

            bool isActive = Panel.activeInHierarchy;
            Panel.SetActive(!isActive);
        }


    }
}
