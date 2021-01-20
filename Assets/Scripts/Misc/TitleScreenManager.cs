using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    [SerializeField] private string levelSceneName = "Prototype";
    public void StartOnClick() {
        SceneManager.LoadScene(levelSceneName);
    }

    public void OptionsOnClick() {
        Debug.Log("Show options menu");
    }

    public void QuitOnClick() {
        Application.Quit();
    }
}
