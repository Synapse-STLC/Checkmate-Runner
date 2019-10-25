using UnityEngine;
using UnityEngine.SceneManagement; //Adding Library for SceneManagement

public class GameManager : MonoBehaviour
{
    //Variable to check if GameOver process has started already
    public bool gameHasEnded = false;
    public bool gameWon = false;

    public GameObject winScreen;

    void Start()
    {
        gameHasEnded = false;
        gameWon = false;
        winScreen.SetActive(false);
    }
    public void GameOver()
    {
        //If the GameOver process haven't started already
        if (!gameWon && !gameHasEnded)
        {
            //Update the Check
            gameHasEnded = true;
            //Call Restart() in 5 seconds
            Invoke("Restart", 5f);
        }

    }

    void Restart()
    {
        //Get the Index number of the Scene
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        //Load the current Scene again (Reload)
        SceneManager.LoadScene(sceneIndex);
    }

    public void GameWon()
    {
        gameWon = true;
        winScreen.SetActive(true);
    }
}
