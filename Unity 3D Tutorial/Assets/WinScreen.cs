using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    int nextSceneIndex;
    void LoadNextLevel()
    {
        //Get the index of the current scene and add 1 
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        //Check if the is a next scene
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            //Go to the next level
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            //Go back to the first level
            SceneManager.LoadScene(0);
        }
    }
}
