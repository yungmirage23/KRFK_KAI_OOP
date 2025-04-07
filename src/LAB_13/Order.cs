namespace LAB_13
{
    internal class Order
    {
        public int Id { get; set; }
        public event EventHandler<OrderStatus> OnOrderStatusChanged;
        public OrderStatus Status { get; set; } = OrderStatus.Unknown;

        public Order(int id)
        {
            Id = id;
        }

        public void CreateOrder()
        {
            Status = OrderStatus.New;
            NotifyStatusChanged();
        }

        public void CancelOrder()
        {
            Status = OrderStatus.Canceled;
            NotifyStatusChanged();
        }


        private void NotifyStatusChanged()
        {
            OnOrderStatusChanged?.Invoke(this, Status);
        }


    }


    


    public enum OrderStatus
    {
        Unknown = 0,
        New,
        Confirmed,
        Ready,
        Canceled
    }
}