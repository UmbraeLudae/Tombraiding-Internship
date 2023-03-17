using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Conversation : ScriptableObject
{
    public List<string> tmpLines;
    public PuzzleNote pageUnlock;
}
