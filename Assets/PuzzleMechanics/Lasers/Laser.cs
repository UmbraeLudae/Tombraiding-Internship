using System;
using UnityEngine;

public struct Laser
{
    public Guid id;
    public Color color;
    public Vector2 direction;
    public enum Color
    {
        RED, BLUE, GREEN, YELLOW, PURPLE, WHITE
    }
    public Laser(Guid id, Vector2 direction, Color color = Color.WHITE)
    {
        this.id = id;
        this.direction = direction;
        this.color = color;
    }

    public override int GetHashCode()
    {
        return id.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        if (!(obj is Laser)) return false;
        return id.Equals(((Laser)obj).id);
    }

    public Laser WithDirection(Vector2 direction) => new(id, direction, color);
    public Laser WithColor(Color color) => new(id, direction, color);
}