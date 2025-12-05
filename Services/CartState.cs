namespace eCommerce_Shop_Client.Services
{
    public class CartState
    {
        public int TotalItems { get;set; }

        public event Action? OnChange;

        public void SetItems(int count)
        {
            TotalItems = count;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
