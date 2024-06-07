using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardSelect : MonoBehaviour
{
    public GameObject[] arts; // Make sure this order matches the ENUM ELEMENTS
    public Elements current;
    public GameObject buttons;

    public void Select(int element)
    {
        current = (Elements)element;
        for (int i = 0; i < arts.Length; i++)
        {
            arts[i].SetActive(i == (int)current);
        }
        buttons.SetActive(false);
    }

    public enum Elements
    {
        // Make sure this matches the order in Arts
        Fire = 0,
        Water = 1,
        Earth = 2,
        Air = 3
    }
}
