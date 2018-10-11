using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour {

    public Sprite Icon;
    public Sprite NotAvalible;
    public Sprite Available;

    public Image IconImage;
    public Image BackGround;

    public int MaxHP;
    public int CurentHP;
    public int posX;
    public int posY;
    public int Group;

    public void SetAvailability(bool isAvalible)
    {
        BackGround.sprite = isAvalible ? Available : NotAvalible;
    }
}
