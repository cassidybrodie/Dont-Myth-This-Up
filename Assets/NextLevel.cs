using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void LevelTwo()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Switching Scene");
    }
}
