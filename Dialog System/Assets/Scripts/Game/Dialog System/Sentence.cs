using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Sentence
{
    public DialogCharacter _character;
    [TextArea(3, 5)] public string _sentence;
} 
