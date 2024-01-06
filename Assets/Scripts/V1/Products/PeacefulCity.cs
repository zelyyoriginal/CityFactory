
using UnityEngine;

public class PeacefulCity : IProduct
{
    public string _name { get; set; } = " PEACEFUL_CITY";
    public Material _material { get; set; }
    

    public PeacefulCity()
    {
      _material =  Resources.Load("CityMaterial") as Material;
    }
    
        public void init(GameObject obj)
        {
            obj.AddComponent<PeacefulCityFactory>();
            obj.name = _name;
            obj.GetComponent<Renderer>().material = _material;

        }
    }
