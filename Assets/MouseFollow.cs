
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    [SerializeField] private Camera cam;
    void Update()
    {
        transform.position = cam.ScreenPointToRay(Input.mousePosition).GetPoint(5f);
    }
}
