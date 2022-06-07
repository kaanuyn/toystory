using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseinfo;
    public GameObject resumeinfo;
    public FirstPersonController firstPersonController;
    



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {

                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        pauseinfo.SetActive(false);
        resumeinfo.SetActive(true);
        firstPersonController.GetComponent<Jump>().canJump = false;

    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        resumeinfo.SetActive(false);
        pauseinfo.SetActive(true);
        new WaitForSeconds(3);
        firstPersonController.GetComponent<Jump>().canJump = false;

    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Start");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
