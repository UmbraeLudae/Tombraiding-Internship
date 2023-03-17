
using UnityEngine;

public class PlayerDebugRollAnimation : MonoBehaviour
{
    [SerializeField] private Mesh Standing, Rolling;
    PlayerRoll cached_PlayerRoll;
    PlayerRoll PlayerRoll => cached_PlayerRoll ??= GetComponent<PlayerRoll>();

    public MeshFilter playerMeshFilter;

    void Update()
    {
        var mesh = PlayerRoll.InRoll ? Rolling : Standing;
        playerMeshFilter.mesh = mesh;
        playerMeshFilter.transform.localPosition = mesh.bounds.extents._0y0();
    }
}
