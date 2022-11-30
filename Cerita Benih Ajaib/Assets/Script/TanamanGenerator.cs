using UnityEngine;

public class TanamanGenerator : MonoBehaviour
{
    public GameObject tanaman;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;


    void Awake()
    {
        currentSpeed = MinSpeed;
        generateTanaman();
    }

    public void generateTanaman()
    {
        GameObject TanamanIns = Instantiate(tanaman, transform.position, transform.rotation);
        TanamanIns.GetComponent<TanamanScript>().tanamanGenerator = this;
    }
}
