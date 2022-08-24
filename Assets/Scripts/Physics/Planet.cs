using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public static Planet planet;
    public List<Rigidbody> objects;

    [SerializeField]private float gravityForce;
    // Start is called before the first frame update

    void Start()
    {
        planet = this;
    }

    //Se utiliza fixed para corregir por frame la posición de los objetos

    private void FixedUpdate()
    {
        foreach (Rigidbody contentObject in objects)
        {
            Vector3 gravityDirection = (contentObject.transform.position - transform.position).normalized;
            Vector3 objectDirection = contentObject.transform.up;
            contentObject.AddForce (gravityDirection * gravityForce * Time.fixedDeltaTime);
            Quaternion nRotation = Quaternion.FromToRotation (objectDirection, gravityDirection) * contentObject.transform.rotation;
            contentObject.transform.rotation = Quaternion.Slerp(contentObject  .transform.rotation, nRotation, 50 * Time.fixedDeltaTime);

        }
        
    }
}
