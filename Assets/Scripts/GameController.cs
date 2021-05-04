using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int num;

    private int countGuess;

    [SerializeField]
    private InputField input;

    [SerializeField]
    private Text text;


    void Awake () {
        //   {input = GameObject.Find ("InputField").GetComponent<InputField>();
        num = Random.Range(0,200);
        text.text = "Guess A Number Between 0 and 200";
         }

    public void GetInput(string guess)
    {
        CompareGuesses(int.Parse(guess));
        input.text = "";
    }

    void CompareGuesses(int guess)
    {
        if(guess == num)
        {
            text.text = "You Guessed Correctly The Number Was" + guess;
        } else if (guess < num) 
        {
            text.text = "Your Guess Number is Less Than The Number You Are Trying to Guess";
        } else if (guess > num)
        {
            text.text = "Your Guess Number is Greater Than The Number You Are Trying to Guess";
        }
   
    }
}
