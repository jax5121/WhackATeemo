using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int sceneIndex;

    public void LoadOtherScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
