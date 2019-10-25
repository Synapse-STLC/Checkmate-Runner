using UnityEngine;
using UnityEngine.UI; //Adding Library for UI control

public class ScoreHandler : MonoBehaviour
{
    //Variables to reference to our Player Object and Text Component
    public Transform player;
    public Text score;

    void Update()
    {
        //Get the Z position of the player and multiply it by 2 and 
        //add 100 so that the game feels more rewarding with the 
        //score system. Then Convert that to a String.
        //The "0" is for ignoring decimal and keeping everything 
        //as an Integer
        score.text = (2f * player.position.z + 100f).ToString("0");
    }
}
