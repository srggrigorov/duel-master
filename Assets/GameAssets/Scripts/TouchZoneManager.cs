using System;
using UnityEngine;

namespace GameAssets.Scripts
{
    public class TouchZoneManager : MonoBehaviour
    {
        [field: SerializeField] public TouchZone OuterTouchZone { get; private set; }
        [field: SerializeField] public TouchZone InnerTouchZone { get; private set; }
    }

    [Serializable]
    public class TouchZone
    {
        [SerializeField] private Vector3 _center;
        [SerializeField] private float _radius;

        public Vector3 Center
        {
            get => _center;
            private set
            {
                if (value != _center)
                {
                    OnZoneChanged?.Invoke();
                    _center = value;
                }
            }
        }

        public float Radius
        {
            get => _radius;
            private set
            {
                if (Math.Abs(value - _radius) < 0.001f)
                    return;

                OnZoneChanged?.Invoke();
                _radius = value;
            }
        }

        public event Action OnZoneChanged;
    }
}