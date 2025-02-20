using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameStateManager;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameManager gameManager;

    public void PlayB()
    {
        SceneManager.LoadScene("Left Scene");
        
        gameManager.StateManager.ChangeState(GameState.Gameplay_State);
    }

    public void QuitB()
    {
        Application.Quit();
    }

    public void MainMenuB()
    {
        SceneManager.LoadScene("Main Menu");

        gameManager.StateManager.ChangeState(GameState.MainMenu_State);
    }

    public void ResumeB()
    {
        gameManager.StateManager.ChangeState(GameState.Gameplay_State);
    }
}
