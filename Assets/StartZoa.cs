using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartZoa : MonoBehaviour
{
    [SerializeField] private string nextSceneName = "PamperScene";

    private void OnMouseDown()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
