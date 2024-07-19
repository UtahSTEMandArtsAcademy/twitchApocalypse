using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainMenuScreenNavigationManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MainMenuDefaultSelect;
    public GameObject Lobby;
    public GameObject LobbyDefaultSelect;
    public GameObject SettingsMenu;
    public GameObject SettingsMenuDefaultSelect;

    public void SwitchMenu(int menu)
    {
        MainMenu.SetActive(false);
        Lobby.SetActive(false);
        SettingsMenu.SetActive(false);

        switch (menu)
        {
            case 0:
                MainMenu.SetActive(true);
                EventSystem.current.SetSelectedGameObject(MainMenuDefaultSelect);
                break;
            case 1:
                Lobby.SetActive(true);
                EventSystem.current.SetSelectedGameObject(LobbyDefaultSelect);
                break;
            case 2:
                SettingsMenu.SetActive(true);
                EventSystem.current.SetSelectedGameObject(SettingsMenuDefaultSelect);
                break;
        }
    }
}
