using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOSE : MonoBehaviour
{

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;




    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();

        quitMenu.enabled = false;


    }


    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;

    }
    public void noPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;

    }

    public void Tutoriapress()
    {
        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;

    }

    public void storypress()
    {
        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;

    }

    public void Startlevel()
    {
        SceneManager.LoadScene("Mapa_01");
    }

    public void ExitGame()

    {
        Application.Quit();
    }
}
