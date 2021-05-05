using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Keybindings", menuName = "Keybindings")]
public class Keybindings : ScriptableObject
{
    public KeyCode number1, number2, number3, number4, number5, number6, number7, number8, number9, number, clear, enter, help;

    public KeyCode CheckKey(string key)
    {
        switch (key)
        {
            case "Number1":
                return number1;

            case "Number2":
                return number1;

            case "Number3":
                return number3;

            case "Number4":
                return number4;

            case "Number5":
                return number5;

            case "Number6":
                return number6;

            case "Number7":
                return number7;

            case "Number8":
                return number8;

            case "Number9":
                return number9;

            case "Number":
                return number;

            case "Clear":
                return clear;

            case "Enter":
                return enter;

            default:
                return KeyCode.None;
        }
    }
}
