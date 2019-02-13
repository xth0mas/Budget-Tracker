namespace ApplicationCore.Entities
{
    public class Expense : BaseEntity
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool Const { get; set; }
    }
}
