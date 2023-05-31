using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace GameAssets.Scripts
{
    public class TouchZoneRenderer : MonoBehaviour
    {
        [SerializeField] private TouchZoneManager _touchZoneManager;
        [SerializeField] private Image _zoneImage;

        private void Awake()
        {
            _touchZoneManager ??= GetComponent<TouchZoneManager>();
            
        }

        public void DrawTouchZone(Vector3 zoneCenter, float zoneRadius)
        {
            
        }
    }

    [CustomEditor(typeof(TouchZoneRenderer))]
    public class TouchZoneRendererEditor : Editor
    {
        
    }
}