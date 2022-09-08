using System;


class ShopProgram {

    public static void Main(string[] args) {
 
            
            Shop createshop = new Shop();
             
             createshop.Shop_name = "Media Coporation";
             createshop.Number = "7124574235102";
             createshop.Owner_Name = "James";
             createshop.input_Registered_Value = "1000000";
             
            
            PrintShopInformation(createshop);
            
            
    }
    
    


    static void PrintShopInformation(Shop shop){

        Console.WriteLine("***********************************");
        Console.WriteLine("Shopname: {0}", shop.Shop_name);
        Console.WriteLine("Number = {0}",shop.Number);
        Console.WriteLine("Owner name = {0}",shop.Owner_Name);
        Console.WriteLine("Registered Value = {0}",shop.input_Registered_Value);
        Console.WriteLine("***********************************");
        

    }
}

    

   

public class Shop {

    public string Shop_name;
    public string Number;
    public string Owner_Name;
    public string input_Registered_Value;


}






        














