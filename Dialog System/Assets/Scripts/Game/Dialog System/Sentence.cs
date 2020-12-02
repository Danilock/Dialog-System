using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Sentence
{
    public DialogCharacter Character;
    [TextArea(3, 5)] public string SentenceText;
    public Texture2D Portrait;
} 
