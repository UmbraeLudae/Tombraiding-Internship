
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    private Door Door => cached_door ??= GetComponent<Door>();
    private Door cached_door;
    [SerializeField] private Transform animatee;
    [SerializeField] private ParticleSystem ps;

    void FixedUpdate()
    {
        var target = Door.IsOpen ? Vector3.up * -3f : Vector3.zero;
        var distance = Vector3.Distance(target, animatee.transform.localPosition);
        animatee.transform.localPosition = Vector3.Lerp(animatee.transform.localPosition, target, .1f);
        ps.gameObject.SetActive(distance > 0.1f);
    }
}
