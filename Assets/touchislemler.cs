using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touchislemler : MonoBehaviour
{
    public Text bilgi;

    public GameObject objem;
    void Update()
    {

        if (Input.touchCount > 0)
        {
            //*********************************************

            //2D
            Vector2 dokunmapos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position); //cam sayesinde dokunduğun yerin pos'u alırsın.
            Instantiate(objem, dokunmapos, Quaternion.identity);

            //********************************************

            // 3D
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hitinfo;
            if (Physics.Raycast(ray, out hitinfo))
            {
                Instantiate(objem, hitinfo.point, Quaternion.identity);
            }//plane dışında boşluğa bastıgında olusturmuyor haci abi. nedir lan bu raycast, sonra görecez umarım.

            //**********************************************





            /*for (int i = 0; i < Input.touchCount; i++)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Moved)
                {
                    bilgi.text += i + ". parmak hareket ediyor\n";
                }
            }*/




            Touch touch = Input.GetTouch(0);

            //bilgi.text = Input.touchCount.ToString() + " adet parmak var.";

            if (Input.GetTouch(0).phase == TouchPhase.Began) //dokunulduğu anda.
            
            if (Input.GetTouch(0).phase == TouchPhase.Stationary) //hareket etmiyor.
            
            if (Input.GetTouch(0).phase == TouchPhase.Moved) //hareket ediyorsa.
            
            if (touch.phase == TouchPhase.Ended) //parmak kaldırıldı.
            
            if (touch.phase == TouchPhase.Canceled) //parmak izleme iptal oldu, sistemsel durumlarda.
            
        }

    }
}
