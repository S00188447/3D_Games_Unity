using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitRay : MonoBehaviour
{
    public float maxDistance = 100;
    public LayerMask layerMask;
    RaycastHit hitResult;
    Ray mouseRay;
    Camera myCamera;


    public Color selectedColor;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(mouseRay, out hitResult,maxDistance, layerMask))
            {
                Vector3 point = hitResult.point;
                Vector3 normal = hitResult.normal;
                Vector2 uv = hitResult.textureCoord;

                MeshRenderer mesh = hitResult.collider.gameObject.GetComponent<MeshRenderer>();
                Material material = mesh.material;
                Texture2D texture = (Texture2D)material.mainTexture;

                selectedColor = texture.GetPixelBilinear(uv.x, uv.y);

                
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(mouseRay);
    }
}
