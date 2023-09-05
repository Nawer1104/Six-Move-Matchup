using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GemType", menuName = "Match3/GemType")]
public class GemType : ScriptableObject
{
    public Sprite sprite;

    public bool speical;

    public int num;
}
