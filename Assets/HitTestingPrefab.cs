using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
public class HitTestingPrefab : MonoBehaviour
{
    public Text textscore;
    float score = 0;
    Vector2 touchposition;
    public Camera arCamera;
    // Start is called before the first frame update
    [SerializeField]
    ARRaycastManager m_RaycastManager;

    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();

    void Update()
    {
        //Rotate the object around itself
        this.transform.Rotate(Vector3.up * 50 * Time.deltaTime, Space.Self);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchposition = touch.position;
            if(touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if(Physics.Raycast(ray, out hitObject))
                {
                    score++;
                    this.gameObject.SetActive(false);        
                }
            }
        }
        textscore.text = "Score: " + score.ToString();
    }
}
