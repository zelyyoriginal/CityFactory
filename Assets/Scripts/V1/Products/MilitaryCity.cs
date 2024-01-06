using UnityEngine;

public class MilitaryCity :  IProduct
{

    public string _name { get; set; } = "MILITTARYCITY";
    public Material _material { get; set; }
    public MilitaryCity()
    {
        _material = Resources.Load("MilitaryMaterial") as Material;
    }
    public void init(GameObject obj)
    {
        obj.AddComponent<MilitaryCityFactory>();
        obj.name = _name;
        obj.GetComponent<Renderer>().material = _material;


    }

}
