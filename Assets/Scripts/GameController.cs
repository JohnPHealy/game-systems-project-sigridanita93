using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int num;

    private int countGuess;

    [SerializeField]
    private GameObject btn;

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
        countGuess++;
    }

    void CompareGuesses(int guess)
    {
        if(guess == num)
        {
            text.text = "You guessed correctly. The number was " + guess + " It took you " + countGuess + "guess(ess) ";
            btn.SetActive(true);
        } else if (guess < num) 
        {
            text.text = "Your guess number is less than the number you are yrying to guess";
        } else if (guess > num)
        {
            text.text = "Your guess number is greater than the number you are trying to guess";
        }
   
    }

    public void UnlockScene()
    {

    }
}
