using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsVisualizer : MonoBehaviour
{
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;

        Gizmos.matrix = this.transform.localToWorldMatrix;
        Mesh m = GetComponent<MeshFilter>().sharedMesh;
        Gizmos.DrawWireCube(m.bounds.center, m.bounds.size);
    }
}
