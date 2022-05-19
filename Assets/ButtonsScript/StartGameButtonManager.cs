using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButtonManager : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("Assets/Scenes/MainScene.unity",LoadSceneMode.Single);
    }
}
