using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShopPanel : MonoBehaviour
{
    public GameObject shopPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        shopPanel.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        shopPanel.SetActive(false);
    }
}
