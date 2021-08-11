using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button PlayButton;
    public Button QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        Button StartB = PlayButton.GetComponent<Button>();
        StartB.onClick.AddListener(PlayMaze);

        Button quitB = QuitButton.GetComponent<Button>();
        quitB.onClick.AddListener(QuitMaze);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>Loads maze scene when button pressed</summary>
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }

    /// <summary>Quits game when button is pushed</summary>
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
