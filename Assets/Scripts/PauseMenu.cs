using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour

{
    public InputActionAsset input;
    private InputAction pause;
    public TMP_Text countdown;
    public GameObject ChildrenOfPause;

    // Start is called before the first frame update
    void Start()
    {   
        pause = input.FindActionMap("Wizard").FindAction("Pause");
        pause.performed += e =>
        {
            ToggleMenu();
        };
        gameObject.SetActive(false);
    }

    public void ToggleMenu() 
    {
        if (gameObject.activeSelf)
        {
            ChildrenOfPause.SetActive(false);
            StartCoroutine(doCountdown());
        }else{
            gameObject.SetActive(true);
            ChildrenOfPause.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void MainMenuReturn() 
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
    private IEnumerator doCountdown() 
    {
        countdown.gameObject.SetActive(true);
        countdown.text = "3...";
        yield return new WaitForSecondsRealtime(1);
        countdown.text = "2...";
        yield return new WaitForSecondsRealtime(1);
        countdown.text = "1...";
        yield return new WaitForSecondsRealtime(1);
        countdown.gameObject.SetActive(false);
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
