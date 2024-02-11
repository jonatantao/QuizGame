using System.Threading.Tasks;
using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    [SerializeField] private Animator dummyAnimator;

    private async void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Arrow") || other.gameObject.CompareTag("Weapon")) {
            dummyAnimator.SetTrigger("Death");
            await Task.Delay(4000);
            ActivateDummy();

        }
    }

    public void ActivateDummy() {
        dummyAnimator.SetTrigger("Activate");
    }
}
