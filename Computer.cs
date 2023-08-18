using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
    
{
    /* Attempted but non-functional
      class Computer
     {
         GamingComputer ComputerGaming = new GamingComputer();
         WorkComputer ComputerWork = new WorkComputer();
         HomeComputer ComputerHome = new HomeComputer();
        
    
        //Properties

         ComputerGaming.Name = Name.text;
         ComputerGaming.PurposeResponse = purposeGameResponse;
         ComputerGaming.Budget = Budget.text;
         ComputerWork.Name = Name.text;
         ComputerWork.PurposeResponse = purposeWorkResponse;
         ComputerWork.Budget = Budget.text;
         ComputerHome.Name = Name.text;
         ComputerHome.PurposeResponse = purposeHomeResponse;
         ComputerHome.Budget = Budget.text;



         public string Name { get; set; }
         public string PurposeResponse { get; set; }
         public double Budget { get; set; }


         //Custom Constructor
         public Computer(string name, string purpose, double budget, string purposeResponse)
         {
             //Store the values in the properties
             Name = name;
             PurposeResponse = purposeResponse;
             Budget = budget;


         }
     }
     //Default constructor
     class GamingComputer : Computer
     {
         public string RecommendedFPS { get; set; }
         public string GamingPrice { get; set; }



         public GamingComputer() : base() { }

         public GamingComputer(string name, string purpose,
         double budget, string recommendedFPS) : base(name, purpose, budget, recommendedFPS)
         {
             recommendedFPS = recommendedFPS;
         }
     }


     class WorkComputer : Computer
     {
         public string RecommendedFPS { get; set; }
         public double WorkPrice { get; set; }
         public WorkComputer() : base() { }

         public WorkComputer(string name, string purpose,
         double budget, string recommendedFPS, double workPrice) : base(name, purpose, budget, recommendedFPS)
         {
             RecommendedFPS = recommendedFPS;
         }
     }

     class HomeComputer : Computer
     {
         public string RecommendedFPS { get; set; }
         public double HomePrice { get; set; }



         public HomeComputer() : base() { }

         public HomeComputer(string name, string purpose,
         double budget, string recommendedFPS, double homePrice) : base(name, purpose, budget, recommendedFPS, homePrice)
         {
             RecommendedFPS = recommendedFPS;
             HomePrice = homePrice;
         }
     }

     */
}
