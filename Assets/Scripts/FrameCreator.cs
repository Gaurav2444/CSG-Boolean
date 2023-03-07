using NaughtyAttributes;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class FrameCreator : MonoBehaviour
{
    public GameObject MeshGO;
    public GameObject Mesh2GO;

    [Button]
    public void CreateOutlineFrame()
    {
        var col = MeshGO.GetComponent<MeshCollider>();
        var mesh = MeshGO.GetComponent<MeshRenderer>();
        Debug.Log(mesh.bounds);
        Debug.Log(mesh.bounds.extents);
        Debug.Log(col.sharedMesh.triangles.Count());

        Mesh2GO.GetComponent<MeshFilter>().sharedMesh.bounds = mesh.bounds;
    }
}
