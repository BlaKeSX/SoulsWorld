using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotation : MonoBehaviour
{
    // ... (otras variables que puedas necesitar)

    void Update()
    {
        // Puedes agregar l�gica espec�fica del arma aqu� si es necesario
    }

    public void UpdateWeaponRotation(Vector2 direccionMirada)
    {
        if (direccionMirada != Vector2.zero)
        {
            float angle = Mathf.Atan2(direccionMirada.y, direccionMirada.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
