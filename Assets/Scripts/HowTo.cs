using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowTo : MonoBehaviour
{
    public Canvas page1;
    public Canvas page2;
    public Canvas page3;

    private int pageNum = 0;

    void FixedUpdate()
    {
        if (pageNum == 0)
        {
            page1.gameObject.SetActive(true);
            page2.gameObject.SetActive(false);
            page3.gameObject.SetActive(false);
        }
        else if (pageNum == 1)
        {
            page1.gameObject.SetActive(false);
            page2.gameObject.SetActive(true);
            page3.gameObject.SetActive(false);
        }
        else if (pageNum == 2)
        {
            page1.gameObject.SetActive(false);
            page2.gameObject.SetActive(false);
            page3.gameObject.SetActive(true);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PageUp()
    {
        if (pageNum < 2) {
            pageNum++;
        }
        else
        {
            pageNum = 0;
        }
    }

    public void PageDown()
    {
        if (pageNum > 0)
        {
            pageNum--;
        }
        else
        {
            pageNum = 2;
        }
    }
}
