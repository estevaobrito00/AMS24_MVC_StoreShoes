class Product
{
    public Guid Id { get; set; }
    public String Brand { get; set; } 
    public Guid ColorId { get; set; }
    public Guid SizeId { get; set; }
    public double Price { get; set; }
    public String Description { get; set; }
    public double Stock { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreateBy { get; set; }
}