using System;
using UnityEngine;

public class PerObjectMaterialProperties : MonoBehaviour
{
    private static MaterialPropertyBlock block;
    
    private static int baseColorId = Shader.PropertyToID("_BaseColor");

    [SerializeField]
    private Color baseColor = Color.white;

    private void OnValidate()
    {
        if (block == null)
        {
            block = new MaterialPropertyBlock();
        }
        block.SetColor(baseColorId, baseColor);
        GetComponent<Renderer>().SetPropertyBlock(block);
    }
}