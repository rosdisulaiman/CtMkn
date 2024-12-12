
namespace CtMkn.Services
{
    public class ToastService
    {
        public event Action<string> OnShowToast;

        public void ShowToast(string message)
        {
            OnShowToast?.Invoke(message);
        }
    }
}
