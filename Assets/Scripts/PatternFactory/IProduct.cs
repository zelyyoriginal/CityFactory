using UnityEngine;

public interface IProduct
{
    public string _name { get; set; }
    public  Material _material { get; set; }

   
    public void init(GameObject obj);
}
