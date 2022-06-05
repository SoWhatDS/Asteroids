using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids.Memento
{
    //public sealed class TimeBody : MonoBehaviour
    //{
    //    [SerializeField] private float _recordTime = 5.0f;
    //    private List<PointInTime> _pointsInTime;
    //    private Rigidbody _rb;
    //    private bool _isRewinding;

    //    private void Start()
    //    {
    //        _pointsInTime = new List<PointInTime>();
    //        _rb = GetComponent<Rigidbody>();
    //        if (Random.Range(0, 100) > 50)
    //        {
    //            var colorHSV = Random.ColorHSV();
    //            var light = new GameObject();
    //            light.transform.SetParent(transform);
    //            var addComponent = light.AddComponent<Light>();
    //            addComponent.color = colorHSV;
    //            addComponent.shadows = LightShadows.Soft;
    //            GetComponent<Renderer>().material.color = colorHSV;
    //        }
    //    }

    //    private void Update()
    //    {
    //        if (Input.GetKeyDown(KeyCode.Space))
    //        {
    //            StartRewind();
    //        }

    //        if (Input.GetKeyUp(KeyCode.Space))
    //        {
    //            StopRewind();
    //        }
    //    }

    //    private void FixedUpdate()
    //    {
    //        if (_isRewinding)
    //        {
    //            Rewind();
    //        }
    //        else 
    //        {
    //            Record();
    //        }
    //    }

    //    private void Rewind()
    //    {
    //        if (_pointsInTime.Count > 1)
    //        {
    //            PointInTime pointInTime = _pointsInTime[0];
    //            transform.position = pointInTime.Position;
    //            transform.rotation = pointInTime.Rotation;
    //            _pointsInTime.RemoveAt(0);
    //        }
    //        else 
    //        {
    //            PointInTime pointInTime = _pointsInTime[0];
    //            transform.position = _pointsInTime.Position;
    //            transform.rotation = _pointsInTime.Rotation;
    //            StopRewind();
    //        }        
    //    }

    //    private void Record()
    //    {
    //        if (_pointsInTime.Count > Mathf.Round(_recordTime / Time.fixedDeltaTime))
    //        {
    //            _pointsInTime.RemoveAt(_pointsInTime.Count - 1);
    //        }

    //        _pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
    //    }

    //    private void StartRewind()
    //    {
    //        _isRewinding = true;
    //        _rb.isKinematic = true;
    //    }

    //    private void StopRewind()
    //    {
    //        _isRewinding = false;
    //        _rb.isKinematic = false;
    //        _rb.velocity = _pointsInTime[0].Velocity;
    //        _rb.angularVelocity = _pointsInTime[0].AngularVelocity;
    //    }
    //}
}
