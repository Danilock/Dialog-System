using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialog Character", menuName = "Dialog Character")]
public class DialogCharacter : ScriptableObject
{
    public string CharacterName;

    public Texture2D[] Portraits;
}
