using System;
using UnityEngine;

public interface IWhippable
{
    Vector2 Position { get; }
    enum WhipInteraction
    {
        Pass, Consume, Long
    }

    WhipInteraction OnWhip(GameObject whipper);
    bool OnWhipStay(GameObject whipper) { throw new NotImplementedException(); }
    void OnWhipEnd(GameObject whipper) { throw new NotImplementedException(); }
}