using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class ColorData : ScriptableObject
{
    public Color value;

    public void ChangeImageColor(Image imgObj)
    {
        imgObj.color = value;
    }

    public void ChangeMeshRenderColor(MeshRenderer meshObj)
    {
        meshObj.material.color = value;
    }

    public void ChangeSpriteRenderColor(SpriteRenderer spriteObj)
    {
        spriteObj.material.color = value;
    }
}
