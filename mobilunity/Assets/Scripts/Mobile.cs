using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour
{

    
    public GameObject touchedObj;

    void Start()
    {
       
    }


    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch inputTouch = Input.GetTouch(0);

            Vector2 touchPos = Camera.main.ScreenToWorldPoint(inputTouch.position);

            if(inputTouch.phase == TouchPhase.Began)
            {
                Collider[] touchedCollider = Physics.OverlapSphere(touchPos, 0.5f);
                if(touchedCollider.Length > 0)
                {
                    touchedObj = touchedCollider[0].gameObject;
                }
            }

            if(inputTouch.phase == TouchPhase.Moved)
            {
                if (touchedObj != null)
                    touchedObj.transform.position = touchPos;
            }


            if (inputTouch.phase == TouchPhase.Ended)
            {
                if(touchedObj != null)
                touchedObj = null;
            }


            #region IlkDers

            //print(inputTouch.position);
            //Vector2 touchPos = Camera.main.ScreenToWorldPoint(inputTouch.position);
            //Instantiate(cube, touchPos, Quaternion.identity);

            //if (inputTouch.phase == TouchPhase.Began)
            //{
            //    print("Began");
            //}
            //if (inputTouch.phase == TouchPhase.Stationary)
            //{
            //    print("Stationary");
            //}
            //if (inputTouch.phase == TouchPhase.Canceled)
            //{
            //    print("Cancel");

            //    if (inputTouch.phase == TouchPhase.Ended)
            //    {
            //        print("Ended");
            //    }
            //    if (inputTouch.phase == TouchPhase.Moved)
            //    {
            //        print("Moved");
            //    }
            //}

            #endregion
        }
    }
    
}
