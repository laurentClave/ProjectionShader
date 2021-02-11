using UnityEngine;

[ExecuteInEditMode]
public class SourceOrigin : MonoBehaviour
{
    [SerializeField]
    private Transform _sourceOrigin;
    [SerializeField]
    private float _angle = 30;
    [SerializeField]
    private Material _projectionMaterial;

    void Update()
    {
        if(_projectionMaterial != null && _sourceOrigin != null)
        {
            _projectionMaterial.SetFloat("Vector1_60695683", _angle);
            _projectionMaterial.SetVector("Vector3_C12940D2", _sourceOrigin.transform.position);
        }
    }
}
