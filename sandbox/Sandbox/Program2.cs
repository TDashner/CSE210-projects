class Program
{
    static void Main(string[]args)
    {
        // Console.WriteLine($"Howdy Sandbox2 World!");
        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.gloves = "latex gloves";
        nurse.shoes = "orthopedic sneakers";
        nurse.shirt = "scrubs";
        nurse.pants = "scrubs";
        nurse.accessory = "stethoscope";
        
        Costume detective = new();
        detective.headWear = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.shirt = "trench coat";
        detective.pants = "slacks";
        detective.accessory = "magnifying glass";

        Costume cowboy = new();
        cowboy.headWear = "cowboy hat";
        cowboy.gloves = "work";
        cowboy.shoes = "boots";
        cowboy.shirt = "vest";
        cowboy.pants = "jeans";
        cowboy.accessory = "lasso";

        Console.WriteLine("Nurse costume:");
        nurse.ShowWardrobe();
        Console.WriteLine("Detective costume:");
        detective.ShowWardrobe();
        Console.WriteLine("Cowboy costume:");
        cowboy.ShowWardrobe();
        
    }
}

