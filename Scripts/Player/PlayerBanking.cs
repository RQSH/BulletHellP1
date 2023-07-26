using UnityEngine;

public class PlayerBanking : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Transform meshTransform;
    [SerializeField] private float bankingAngle;
    [SerializeField] private float bankingSensitivity;

    private void Update()
    {
        Quaternion targetAngle = Quaternion.Euler(0, 0, -bankingAngle * playerController.XInput());
        meshTransform.rotation = Quaternion.Slerp(meshTransform.rotation, meshTransform.parent.rotation * targetAngle, Time.deltaTime * bankingSensitivity);
    }
}