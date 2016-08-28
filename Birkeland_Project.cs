using System;
struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{
    public static void Main()
    {		
            string strx=Console.ReadLine();		

            optx = int.Parse(strx); 

            Console.WriteLine(); 
			
            switch(optx)
            {
                case 1:	
                {
                    Console.Write("Please enter an item ID No:");
                    string stritemid = Console.ReadLine();
                    int itemid=int.Parse(stritemid);
                    bool ffound = true;

                    Console.Write("Please enter an item Description:");
                    string description = Console.ReadLine();
                    
                    Console.Write("Please enter Price Per Item:");
                    string strprice = Console.ReadLine();
                    double price=double.Parse(strprice);

                    Console.Write("Please enter Quanity on Hand");
                    string strquantity = Console.ReadLine();
                    int quantity=double.Parse(strquantity);

                    Console.Write("Please enter Our Cost Per Item:");
                    string strcost = Console.ReadLine();
                    double cost=double.Parse(strcost);

                    Console.Write("Please enter Value of Item:");
                    string strvalue = Console.ReadLine();
                    double value=double.Parse(strvalue);               
        
                    break;
                }

                case 2: 
                {
                    Console.Write("Please enter an item ID No:");
                    string strchgid=Console.ReadLine();
                    int chgid=int.Parse(strchgid);
                    bool fFound = false;
					
                    for(int x=0; x<icount; x++)
                    {
                        if(itemprop[x].itemIDNo==chgid)
                        {
                            fFound = true;

                            Console.WriteLine("ItemIDNo: {0}", Itemdata.ItemIDNo);
                            Console.WriteLine("Item Description:  {0}", ItemData.sDescription);
                            Console.WriteLine("Price Per Item:  {0}", ItemData.dblPricePerItem);
                            Console.WriteLine("Quantity on Hand:  {0}", ItemData.iQuantityOnhand);
                            Console.WriteLine("Our Cost Per Item:  {0}", ItemData.dblOurCostPerItem);
                            Console.WriteLine("Value of item:  {0}", ItemData.dblValueofItem);
                            
                         }
                    }

                    if (!fFound) 
                    {
                        Console.WriteLine("Item {0} not found", chgid);
                    }

                    break;
                }

                case 3: 
                {
                    Console.Write("Please enter an item ID No:");
                    string strnewid=Console.ReadLine();
                    int newid=int.Parse(strnewid);
                    bool fDeleted = false;
					
                    for(int x=0; x<icount; x++)
                    {
                        if(itemprop[x].itemIDNo==newid)
                        {
                            fDeleted = true;
                            
                           								
                        }
                    }
                    
                    if (fDeleted) 
                    {
                        Console.WriteLine("Item deleted");
                    }
                    else 
                    {
                        Console.WriteLine("Item {0} not found", newid);
                    }

                    break;
                }

                case 4:	 
                {
                    Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                    Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");
                    
                    
                    break;
                }

                
                case 5: 
                {
                    Console.Write("Are you sure that you want to quit(y/n)?");
                    string strresp = Console.ReadLine();
					
                    if (
                    {
                        optx=0;		
                    }
                    break;
                }

                default:
                {
                    Console.Write("Invalid Option, try again");
                    break;
                }
            }
        }		
    }
}