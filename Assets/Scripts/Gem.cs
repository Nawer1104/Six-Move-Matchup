using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Gem : MonoBehaviour
{
    public GemType type;

    public bool special;

    public void SetType(GemType type)
    {
        this.type = type;
        this.special = type.speical;
        GetComponent<SpriteRenderer>().sprite = type.sprite;
    }

    public GemType GetType() => type;

    public int SetTextNumOfType()
    {
        if (type.num > 0)
        {
            type.num -= 1;
        }
        else
        {
            type.num = 6;
        }
        return type.num;
    }

}
