using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button PlayButton;

    // Start is called before the first frame update
    void Start()
    {
        Button StartB = PlayButton.GetComponent<Button>();
        StartB.onClick.AddListener(PlayMaze);
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
}
