using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;
    public Canvas TutoriaText;
    public Button backtext;
    public Canvas storytext;
    public Button back2;



    void Start () {
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        TutoriaText = TutoriaText.GetComponent<Canvas>();
        backtext = backtext.GetComponent<Button>();
        storytext = storytext.GetComponent<Canvas>();
        back2 = back2.GetComponent<Button>();
        quitMenu.enabled = false;
        TutoriaText.enabled = false;
        backtext.enabled = false;
        startText.enabled = true;
        storytext.enabled = false;
        back2.enabled = false;

}


    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        TutoriaText.enabled = false;
        backtext.enabled = false;
        storytext.enabled = false;
        back2.enabled = false;
    }
    public void noPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        TutoriaText.enabled = false;
        backtext.enabled = false;
        storytext.enabled = false;
        back2.enabled = false;
    }

    public void Tutoriapress()
    {
        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        TutoriaText.enabled = true;
        backtext.enabled = true;
        storytext.enabled = false;
        back2.enabled = false;
    }

    public void storypress()
    {
        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        TutoriaText.enabled = false;
        backtext.enabled = false;
        storytext.enabled = true;
        back2.enabled = true;
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
