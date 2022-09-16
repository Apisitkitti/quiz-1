using System;
public class program
{
    public static void Main()
    {
        
      Restaurant_info Information = new Restaurant_info ();
      Founder Member = new Founder();
      worker employee = new worker();
      Reciever_buyer outut = new Reciever_buyer(); 
     string Choose = Chooser();
     int stringtoint = ConvertStringtoInt(Choose);
      Display_Choser(stringtoint,Information,Member,employee,outut);
    }
    public static void Display_Choser(int num,Restaurant_info info, Founder mem,worker eployee,Reciever_buyer money)
    {
        if(First_menu(num))
        {
            Shopinfo_display(info);
        }
        else if(Sec_menu(num))
        {
           Founder_dispay(mem);
        }
        else if(Third_menu(num))
        {
             Worker_display(eployee);
        }
        else if(Fourth_menu(num))
        {
            Money_display(money);
        }
    }
    public static void Shopinfo_display(Restaurant_info info)
    {
        
            Console.WriteLine("******************************************************************");
            Console.WriteLine("Finance: {0}",info.Money);
            Console.WriteLine("******************************************************************");
            Console.WriteLine("Branch name: {0}",info.Branch_name);
            Console.WriteLine("******************************************************************");
            Console.WriteLine("Where: {0}",info.Where);
            Console.WriteLine("******************************************************************");
           
           
    }
    public static void Founder_dispay(Founder mem)
    {
         for(int i =0; i<3;i++)
            {
                
                Console.WriteLine("Name:{0}  Surname:{1}  ID:{2}",mem.Founder_Name[i],mem.Founder_Surname[i],mem.ID[i]);
                Console.WriteLine("******************************************************************");
            } 
    }
    
    public static void Worker_display(worker member)
    {
                
                Console.WriteLine("Position: {0} Name: {1}  Surname:{2}  Age: {3} Salary:{4}",member.Position[0],member.Worker_name[0],member.Worker_Surname[0],member.Worker_age[0],member.Salary[0]);
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Position: {0} Name: {1}  Surname:{2}  Age: {3} Salary: {4}",member.Position[0],member.Worker_name[1],member.Worker_Surname[1],member.Worker_age[1],member.Salary[0]);
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Position: {0} Name: {1}  Surname:{2}  Age: {3} Salary: {4}",member.Position[0],member.Worker_name[2],member.Worker_Surname[2],member.Worker_age[2],member.Salary[0]);
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Position: {0} Name: {1}  Surname:{2}  Age: {3} Salary: {4}",member.Position[1],member.Worker_name[3],member.Worker_Surname[3],member.Worker_age[3],member.Salary[1]);
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Position: {0} Name: {1}  Surname:{2}  Age: {3} Salary: {4}",member.Position[1],member.Worker_name[4],member.Worker_Surname[4],member.Worker_age[4],member.Salary[1]);
                Console.WriteLine("******************************************************************");
    
    }
    public static void Money_display(Reciever_buyer money)
    {
        Console.WriteLine("******************************************************************");
        Console.WriteLine("All recieve: {0:f2}",money.Money_reciver);
        Console.WriteLine("All expense: {0:f2}",money.Money_Out);
        Console.WriteLine("All Left: {0:f2}",money.least);
        Console.WriteLine("******************************************************************");
    
    
    
    
    }
    


    public static bool First_menu(int number)
    {
        return number==1;
    }
    public static bool Sec_menu(int number)
    {
        return number==2;
    }
    public static bool Third_menu(int number)
    {
        return number==3;
    }
    public static bool Fourth_menu(int number)
    {
        return number==4;
    }


    public static string Chooser()
    {
        Console.WriteLine("Choose Menu \n1.Restaurant info\n2.Founder\n3.Worker\n4.Receiver/Expenses");
        return Console.ReadLine();
    }
    public static int ConvertStringtoInt(string Num)
    {
        if(int.TryParse(Num,out int Value))
        {
            return Value;
        }
        throw new Exception("Pls Choose again");
    }

}



