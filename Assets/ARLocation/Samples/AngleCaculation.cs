using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCaculation : MonoBehaviour
{
    double gpsRadios = 0;
    public float radiosValue = 0;

    double myLat1 = 10.7570387;
    double myLon1 = 106.6936839;

    double myLat2 = 10.7570458;
    double myLon2 = 106.694169;

    double LatVolumne = 111350;
    double LonVolumne = 91170;

    public Transform locationA;
    public Transform locationB;
    public Transform target;
    bool isRotate = false;
    // Start is called before the first frame update
    void Start()
    {
        isRotate = true;
    }
    // Update is called once per frame
    void Update()
    {
            //Caculate Angle by GPS meter
            var meterLat1 = myLat1 * LatVolumne; // y1
            var meterLon1 = myLon1 * LonVolumne; // x1

            var meterLat2 = myLat2 * LatVolumne; // y2
            var meterLon2 = myLon2 * LonVolumne; // x2

            print("debug lat y:" + (meterLat1 - meterLat2));
            print("debug lon x:" + (meterLon1 - meterLon2));

            var valuex = meterLon1 - meterLon2;
            var valuey = meterLat1 - meterLat2;

            double angle = (valuey / valuex) * 180 / Mathf.PI;
            Debug.Log("The degree by meter is: " + angle);

            //var radian = 180 * (Mathf.PI / 180);
            //var x = Mathf.Cos(radian) * target.transform.position.x - Mathf.Sin(radian) * target.transform.position.z;
            //var z = Mathf.Sin(radian) * target.transform.position.x - Mathf.Cos(radian) * target.transform.position.z;
            //target.transform.position.x = x;
            //target.transform.position.z = z;

            //Caculate Angle by transform position
            double angleposition = Mathf.Atan2(locationA.transform.position.x - locationB.transform.position.x, locationA.transform.position.z - locationB.transform.position.z) * Mathf.Rad2Deg;
            Debug.Log("The degree by position is:" + angleposition);

            //float anglefromto = Vector3.Angle(locationA.position - locationB.position, transform.forward);
            //Debug.Log("The degree by fromto is: " + anglefromto);

            //AR and GPS difference in angle degrees
            radiosValue = (float)(angle - angleposition) + 90;
            Debug.Log("Angle difference bwt AR & GPS: " + radiosValue);
            if(isRotate)
                {
                    target.transform.Rotate(0f, radiosValue, 0f);
                    isRotate = false;
                }
    }
}
