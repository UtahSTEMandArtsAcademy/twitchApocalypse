using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class WizardSelect : MonoBehaviour
{
    public GameObject[] arts; // Make sure this order matches the ENUM ELEMENTS
    public Elements current;
    public GameObject buttons;
    public bool changing;
    public TMP_Text changingButton;
    public GameObject readySign;
    public TMP_Text readyButtonText;
    public TMP_Text nameObject;
    public bool ready = false;

    void Awake()
    {
        nameObject.text = transform.parent.name;
    }

    public void ToggleChange()
    {
        changing = !changing;
        buttons.SetActive(changing);
        changingButton.text = changing ? "Cancel" : "Change";
        if (ready)
        {
            ready = false;
            readySign.SetActive(ready);
        }
        readyButtonText.text = changing ? "Can't Ready": "Ready";
    }

    public void Select(int element)
    {
        current = (Elements)element;
        for (int i = 0; i < arts.Length; i++)
        {
            arts[i].SetActive(i == (int)current);
        }
        buttons.SetActive(false);
        changing = false;
        changingButton.text = "Change";
        readyButtonText.text = "Ready";
        EventSystem.current.SetSelectedGameObject(changingButton.transform.parent.gameObject);
    }

    public void ReadyButton()
    {
        if (changing)
        {
            return;
        }
        ready = !ready;
        readySign.SetActive(ready);
        readyButtonText.text = ready ? "Unready" : "Ready";
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
