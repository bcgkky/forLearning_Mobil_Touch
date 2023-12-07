using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputgirisleri : MonoBehaviour
{
    float hiz = 10;

    Rigidbody rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float forhori = Input.GetAxis("Horizontal");
        float forverti = Input.GetAxis("Vertical");
        float forjump = Input.GetAxis("Jump");
        //transform.Translate(new Vector3(forhori,forjump,forverti) * hiz * Time.deltaTime);

        Vector3 myvek = new Vector3(forhori, forjump, forverti);
        rb.AddForce(myvek * hiz);
    }
    
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.H))
        {
            print("çek lan elini H den it");
        }



        /*if (Input.GetButton("Fire1"))
        {
            print("etkileşim sürüyor");
        }
        if (Input.GetButtonDown("Fire1"))
        {
            print("etkileşim oldu");
        }
        if (Input.GetButtonUp("Fire1"))
        {
            print("etkileşim bitti");
        }*/


        /*if (Input.GetMouseButton(0))
        {
            print("sol tık");
        }
        if (Input.GetMouseButton(1))
        {
            print("sağ tık");
        }
        if (Input.GetMouseButton(2))
        {
            print("orta tık");
        }*/

        /*if (Input.anyKeyDown)
        {
            print("var");
        }*/

        /*if (Input.anyKey)
        {
            print("var");
        }*/







        /*if (Input.GetKey("a"))
        {
            print("a basıldı");
        }*/

        /*if (Input.GetKeyDown("a"))
        {
            print("a basıldı");
        }*/

        /*if (Input.GetKeyUp("a"))
        {
            print("a basıldı");
        }*/

    }
}
