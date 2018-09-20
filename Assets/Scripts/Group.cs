using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public struct CharAndPosition
{
    public Character Character;
    public int posX;
    public int posY;
}

public class Group : MonoBehaviour {
    public List<CharAndPosition> Characters;
}
