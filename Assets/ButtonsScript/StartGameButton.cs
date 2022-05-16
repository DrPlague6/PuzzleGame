using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public void doStartGame(){
        Application.Quit();
        SceneManager.LoadScene("Assets/Scenes/MainScene.unity",LoadSceneMode.Single);
    }
}
