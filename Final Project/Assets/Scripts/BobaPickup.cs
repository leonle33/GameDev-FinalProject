using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobaPickup : MonoBehaviour
{
    [SerializeField] AudioClip ammo;

    private void OnTriggerEnter2D(Collider2D other)
    {
        ProjectileThrower projectileThrower = other.gameObject.GetComponentInChildren<ProjectileThrower>();

        if (projectileThrower)
        {
            GetComponent<AudioSource>().PlayOneShot(ammo);

            AudioSource.PlayClipAtPoint(ammo, transform.position);
            if (this.tag == "FloorBoba")
            {
                projectileThrower.AddBoba(5, 0, 0);
            }

            if (this.tag == "FloorBlueBoba")
            {
                projectileThrower.AddBoba(0, 2, 0);
            }

            if (this.tag == "FloorRedBoba")
            {
                projectileThrower.AddBoba(0, 0, 1);
            }
            // projectileThrower.AddBoba(projectileThrower.ammoSize, 0, 0);
            //Debug.Log("i picked up boba");
            if (other.tag == "Player")
            {

                Destroy(gameObject);

            }

            else
            {
                Debug.Log("i picked up boba: " + other.tag);
                Physics2D.IgnoreCollision(GetComponent<Collider2D>(), other, true);
            }

        }

    }


}
