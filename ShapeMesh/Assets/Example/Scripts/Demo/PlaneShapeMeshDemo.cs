using UnityEngine;

namespace SimpleCore.ShapeMeshes.Example
{
    public class PlaneShapeMeshDemo : MonoBehaviour
    {
        #region public members

        public MeshPivot meshPivot = MeshPivot.Center;

        #endregion

        #region unity functions

        private void Start()
        {
            var tempGo = new GameObject("PlaneShape");
            var meshFilter = tempGo.AddComponent<MeshFilter>();
            meshFilter.mesh = ShapeMeshFactory.GeneratePlaneShapeMesh(5, 5, meshPivot: meshPivot);
            tempGo.AddComponent<MeshRenderer>().material = Resources.Load<Material>("Material");
            tempGo.AddComponent<MeshDisplay>();
        }

        #endregion
    }
}