using UnityEngine;

public class ConstantWeightProvider : MonoBehaviour, IWeightProvider
{
    [SerializeField] private float weight;
    public float Weight => weight;
}
