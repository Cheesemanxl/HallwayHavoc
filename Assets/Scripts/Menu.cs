using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private bool female;
    public Transform highlight;

    void FixedUpdate()
    {
        if (highlight != null) {
            if (female)
            {
                highlight.position = new Vector3(5.0f, -3.425f, 0.0f);
            }
            else
            {
                highlight.position = new Vector3(6.95f, -3.425f, 0.0f);
            }
        }
    }

    public void Retry()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {

        Application.Quit();
    }

    public void ToggleGender()
    {

        if (female)
        {
            female = false;
        }
        else
        {
            female = true;
        }
    }

    public void SetGenderMale()
    {

        female = false;
    }

    public void SetGenderFemale()
    {

        female = true;
    }

    public void StartGame()
    {
        if (female)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }

    public void OpenHowTo()
    {
        SceneManager.LoadScene(3);
    }
}
