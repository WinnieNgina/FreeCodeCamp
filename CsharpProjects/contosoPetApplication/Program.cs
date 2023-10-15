List<List <string>> ourAnimals = new List<List<string>>();



// int seed = 0;

// Console.WriteLine("Do you want to enter an animal [Y] [N]");

// if(userInput == "N")
// {
//     seed += 1;    
// }

// string[] ourAnimals = new string[seed];

// string[] menu = {"allAnimals", "addNew"}
// the ourAnimals array will store the following: 
// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";

// variables that support data entry
// int maxPets = 8;
// string? readResult;
// string menuSelection = "";

// array used to store runtime data, there is no persisted data
// string[,] ourAnimals = new string[maxPets, 6];
Console.WriteLine("Welcome to Contoso Pet Application.\nHow can we assist you?");

while(true)
{
    Console.WriteLine(" 1. view all animals \n 2. add an animal to our shelter \n 3. Ensure animal ages and physical descriptions are complete.\n 4. Ensure animal nicknames and personality descriptions are complete.\n 5. Edit an animal’s age. \n 6. Edit an animal’s personality description.\n 7. Display all cats with a specified characteristic. \n 8. Display all dogs with a specified characteristic.");

    string? userInput = Console.ReadLine();


    switch(userInput)
    {
        case "1":
            Console.WriteLine($"\n\nPet Id\tSpecies\tAge\tNickname\tPersonality\tDescription");
            foreach (var animal in ourAnimals)
            {
                // int counter = 0;
                
                Console.WriteLine($"\n {animal[0]}\t{animal[1]}\t{animal[2]}\t{animal[3]}\t{animal[4]}\t");
            }
            break;
        case "2":
            var Pet = new List <string>();
            string[] attributes = {"Please enter animal species", "Enter pet age", "Please enter the pet nickname", "Enter pet personality", "Provide description for yout pet"}; 
            foreach(var attr in attributes)
            {
                Console.WriteLine(attr);
                string? input = Console.ReadLine();
                if (input != null)
                {
                    Pet.Add(input);
                }
            }
            foreach(var petAttr in Pet)
            {
                Console.WriteLine(petAttr);
            }
            ourAnimals.Add(Pet);

            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            break;
        case "8":
            break;
         case "Exit":
            break;
            
        default:
            Console.WriteLine("Enter a valid menu Item");
            break;
    }
    if (userInput == "Exit")
    {
        break;
    }

}

Console.WriteLine("Goodbye!!!");