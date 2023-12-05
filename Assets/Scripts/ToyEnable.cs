using UnityEngine;

public class ToyEnable : MonoBehaviour
{
    public GameObject Toy;

    private void OnMouseDown()
    {
        Toy.SetActive(!Toy.activeSelf);
    }
}
