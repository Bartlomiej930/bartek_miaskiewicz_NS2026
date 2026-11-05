using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
    public List<int> jedynki = new List<int>();
    public List<int> dwojki = new List<int>();
    public List<int> trojki = new List<int>();
    public List<GameObject> ksztalty;
    public Gradient Grad;
    // Start is called before the first frame update
    void Start()
    {
        Zadanie2();
        for (int i = 0; i < dane.Count; i++)
        {
            if (dane[i] == 1)
            {
                jedynki.Add(1);
            }
            else if (dane[i] == 2)
            {
                dwojki.Add(1);
            }
            else if (dane[i] == 3)
            {
                trojki.Add(1);
            }
        }

        Debug.Log(dane.Count);
        Debug.Log(jedynki.Count);
        Debug.Log(dwojki.Count);
        Debug.Log(trojki.Count);
    }
    private void Zadanie2()
    {
        foreach (GameObject obj in ksztalty)
        {
            if (obj.GetComponent<MeshRenderer>() !=null)
            {
                Debug.Log("3D");
                Cube(obj.transform);
            }
            else if (obj.GetComponent<SpriteRenderer>() != null)
            {
                Debug.Log("2D");
                Sprite(obj.GetComponent<SpriteRenderer>());

            }
        }
    }
    //private void Zadanie3()
    //{
    //    foreach (GameObject obj in ksztalty)
    //    {
    //        if (obj.GetComponent<Transform>() !=null)
    //        {
    //            Debug.Log("EveryObject");
    //        }
    //    }
    //}
    private void Sprite(SpriteRenderer sprite)
    {
        float Y = sprite.transform.position.y;
        sprite.color = Grad.Evaluate(Y);
      
    }
    private void Cube(Transform kostka)
    {
        float X = kostka.position.x;
        kostka.rotation = Quaternion.Euler(X*10, 0, 0);
    }


    // Update is called once per frame
    void Update()
    {
        Zadanie2();

    }
}
