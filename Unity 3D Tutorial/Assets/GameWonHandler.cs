using UnityEngine;

public class GameWonHandler : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().GameWon();
    }
}
