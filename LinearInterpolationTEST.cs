using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolationTEST : MonoBehaviour
{
    public Transform MoveObj;
    public Transform StartPoint;
    public Transform FinishPoint;

    private bool _isMove = false;

    public float Duration = 2;
    private float _time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            _isMove = true;
        }

        if (_isMove)
        {
            _time += Time.deltaTime;
            float alpha = _time / Duration;
            _time = Mathf.Clamp01(_time);
            MoveObj.position = Vector3.Lerp(StartPoint.position, FinishPoint.position, alpha);
            if(alpha >= 1)
            {
                _time = 0;
                _isMove = false;
            }
        }
    }
}
