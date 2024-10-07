class Costume
{
    // attributes (member variables)
    public string headWear;
    public string gloves;
    public string shoes;
    public string shirt;
    public string pants;
    public string accessory;

    // behaviors (member functions, or *methods*)
    public void ShowWardrobe()
    {
        string result = "";
        result += "Head wear: " + headWear;
        result += "\nGloves: " + gloves;
        result += "\nShoes: " + shoes;
        result += "\nShirt: " + shirt;
        result += "\nPants: " + pants;
        result += "\nAccessory: " + accessory;
        Console.WriteLine(result);
    }

}