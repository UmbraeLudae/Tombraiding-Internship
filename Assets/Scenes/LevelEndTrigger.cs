
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class LevelEndTrigger : MonoBehaviour
{
    void OnTriggerEnter() => LevelLoader.Next();
}
